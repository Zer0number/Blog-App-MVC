using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Article
    {
        public int? ArticleId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string MainContent { get; set; }
        [Required]
        public string Date { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
