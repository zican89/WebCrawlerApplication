using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCrawlerApplication.Models
{
    public class CrawlerStartModel
    {
        [Key]
        [Required]
        public string URL { get; set; }
        [Required]
        public string Expression { get; set; }
        public int Depth { get; set; }
    }
}
