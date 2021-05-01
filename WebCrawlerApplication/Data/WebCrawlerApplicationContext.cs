using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCrawlerApplication.Models;

namespace WebCrawlerApplication.Data
{
    public class WebCrawlerApplicationContext : DbContext
    {
        public WebCrawlerApplicationContext (DbContextOptions<WebCrawlerApplicationContext> options)
            : base(options)
        {
        }


        public DbSet<User> User { get; set; }
        public DbSet<CrawlerSearch> CrawlerSearch { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 1,
                Email = "test@test",
                Password ="test"
            });
        }
    }
}
