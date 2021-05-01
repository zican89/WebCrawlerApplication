using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerApplication.Data;
using WebCrawlerApplication.Models;
using WebCrawlerApplication.Repositories;

namespace WebCrawlerApplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> DoesUserExist(LoginModel userLogin)
        {
            User user = await _userRepository.GetUser(userLogin.Email, userLogin.Password);

            if (user==null)
                return false;
            else
                return true;
        }

    }
}
