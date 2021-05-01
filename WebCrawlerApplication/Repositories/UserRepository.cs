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

        public async Task<User> GetUser(string email, string password)
        {
            return  await _context.User.SingleOrDefaultAsync(x => x.Email == email && x.Password==password);
        }
    }
}
