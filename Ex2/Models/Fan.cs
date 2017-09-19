using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ex2.Models
{   
    public enum Gender
    {
        Male, Female, Other // cuz we are in 2017
    }

    public class Fan
    {
        [Key]
        public int FanId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender UserGender { get; set; }
        public DateTime BirthDate { get; set; }
        public int Vetek { get; set; }
    }
}