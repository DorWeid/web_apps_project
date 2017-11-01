using System.ComponentModel.DataAnnotations;

namespace Ex2.Models
{
    public class TweetToBe
    {
        [Key]
        public int TweetID { get; set; }
        public string Text { get; set; }
    }
}