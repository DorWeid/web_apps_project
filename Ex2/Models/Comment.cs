using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSiteURL { get; set; }
        public string Content { get; set; }
        public virtual Post Post { get; set; }
    }
}