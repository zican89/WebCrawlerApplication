using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerApplication.Models;

namespace WebCrawlerApplication.Services
{
    public interface ICrawlerSearchService
    {
        Task CrawlerStart(CrawlerStartModel crawlerStartModel);
        Task<List<ReportModel>> GetCrawlerSearches();
    }
}
