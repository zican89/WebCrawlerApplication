using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerApplication.Data;

namespace WebCrawlerApplication.Repositories
{
    public interface ICrawlerSearchRepository
    {
        Task InsertCrawlerSearch(CrawlerSearch crawlerSearch);
        Task<List<CrawlerSearch>> GetCrawlerSearches();
    }
}
