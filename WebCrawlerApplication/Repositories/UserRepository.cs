using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerApplication.Data;

namespace WebCrawlerApplication.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WebCrawlerApplicationContext _context;

        public UserRepository(WebCrawlerApplicationContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(int id)
        {
            return  await _context.User.FirstAsync(x => x.ID == id);
        }
    }
}
