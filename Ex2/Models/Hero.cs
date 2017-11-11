using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2.Models
{
    public enum Role
    {
        Attack, Defender, Tank, Support
    }

    public enum AttackStyle
    {
        Melee, Range
    }

    public class Hero
    {
        [Key]
        public int HeroID { get; set; }
        [Required]
        public string Name { get; set; }
        public Role HeroRole { get; set; }
        [Required]
        public int HP { get; set; }
        public AttackStyle AttackStyle { get; set; }
    }
}