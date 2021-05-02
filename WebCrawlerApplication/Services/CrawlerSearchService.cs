using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebCrawlerApplication.Data;
using WebCrawlerApplication.Models;
using WebCrawlerApplication.Repositories;

namespace WebCrawlerApplication.Services
{
    public class CrawlerSearchService : ICrawlerSearchService
    {
        private readonly ICrawlerSearchRepository _crawlerSearchRepository;

        public CrawlerSearchService(ICrawlerSearchRepository crawlerSearchRepository)
        {
            _crawlerSearchRepository = crawlerSearchRepository;
        }

        public async Task CrawlerStart(CrawlerStartModel crawlerStartModel)
        {
            List<string> controlledSites = new List<string>();
            await Search(crawlerStartModel, 0, controlledSites);
        }

        private async Task Search(CrawlerStartModel crawlerStartModel, int currentDepth, List<string> controlledSites)
        {
            if (!controlledSites.Any(x=> x==crawlerStartModel.URL))
            {
                WebRequest wr = WebRequest.Create(crawlerStartModel.URL);
                WebResponse ws = wr.GetResponse();
                StreamReader sr = new StreamReader(ws.GetResponseStream(), Encoding.UTF8);
                string response = sr.ReadToEnd();
                sr.Close();
                ws.Close();

                CrawlerSearch crawlerSearchResult = new CrawlerSearch()
                {
                    Date = DateTime.Now,
                    URL = crawlerStartModel.URL,
                    Expression = crawlerStartModel.Expression,
                };

                if (response.Length > 0)
                    crawlerSearchResult.HitCount = response.Split(crawlerStartModel.Expression).Count() - 1;
                else
                    crawlerSearchResult.HitCount = 0;

                await _crawlerSearchRepository.InsertCrawlerSearch(crawlerSearchResult);

                controlledSites.Add(crawlerStartModel.URL);

                if (crawlerStartModel.Depth - 1 > currentDepth)
                {
                    List<string> subsites = FindSubSites(response);
                    currentDepth++;

                    foreach (var item in subsites)
                    {
                        await Search(new CrawlerStartModel()
                        {
                            URL = item,
                            Expression = crawlerStartModel.Expression,
                            Depth = crawlerStartModel.Depth
                        }, currentDepth, controlledSites);
                    }
                }
            }
        }

        private List<string> FindSubSites(string currentSite)
        {
            List<string> subSites = new List<string>();

            Regex regx = new Regex("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?", RegexOptions.IgnoreCase);
            MatchCollection mactches = regx.Matches(currentSite);
            foreach (Match match in mactches)
            {
                subSites.Add(match.Value);
            }

            return subSites;
        }





    }
}
