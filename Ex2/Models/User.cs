using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string nickname { get; set; }
        public Hero MainHero { get; set; }
    }
}