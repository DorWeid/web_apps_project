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
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public int HeroID { get; set; }
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public virtual Hero MainHero { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

    public class GroupByHeroModel
    {
        public int HeroId { get; set; }
        public string HeroName { get; set; }
        public int TotalPosts { get; set; }

    }
}