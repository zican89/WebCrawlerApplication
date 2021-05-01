using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerApplication.Data;

namespace WebCrawlerApplication.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUser(string email, string password);
    }
}
