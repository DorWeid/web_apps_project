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
        public int MainHeroId { get; set; }
        public virtual Hero MainHero { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}