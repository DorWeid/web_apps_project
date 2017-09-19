using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSiteURL { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public string VideoURL { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}