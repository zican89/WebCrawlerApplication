using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCrawlerApplication.Data
{
    public class CrawlerSearch
    {
        public int ID { get; set; }
        public string Crawlername { get; set; }
        public DateTime Date { get; set; }
        public string URL { get; set; }
        public string Expression { get; set; }
        public int HitCount { get; set; }
    }
}
