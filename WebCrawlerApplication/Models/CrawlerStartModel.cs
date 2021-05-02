using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCrawlerApplication.Models
{
    public class CrawlerStartModel
    {
        [Required]
        public string URL { get; set; }
        [Required]
        public string Expression { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Search Depth cannot be a negative number")]
        public int? Depth { get; set; }
    }
}
