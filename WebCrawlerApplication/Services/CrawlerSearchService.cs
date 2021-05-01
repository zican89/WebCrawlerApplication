using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
