using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCrawlerApplication.Models
{
    public class ReportModel
    {
        public string Crawlername { get; set; }
        public DateTime Date { get; set; }
        public string URL { get; set; }
        public string Expression { get; set; }
        public int HitCount { get; set; }
    }
}
