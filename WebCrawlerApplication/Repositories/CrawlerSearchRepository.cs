using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerApplication.Data;

namespace WebCrawlerApplication.Repositories
{
    public class CrawlerSearchRepository : ICrawlerSearchRepository
    {
        private readonly WebCrawlerApplicationContext _context;

        public CrawlerSearchRepository(WebCrawlerApplicationContext context)
        {
            _context = context;
        }
        public async Task InsertCrawlerSearch(CrawlerSearch crawlerSearch)
        {
            await _context.CrawlerSearch.AddAsync(crawlerSearch);
            await _context.SaveChangesAsync();
        }
        public async Task<List<CrawlerSearch>> GetCrawlerSearches()
        {
            return await _context.CrawlerSearch.ToListAsync();
        }
    }
}
