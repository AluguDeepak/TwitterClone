using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TwitterCaseStudy.Models
{
    [Table("Tweets")]
    public class Tweet
    {
        [Key]
        public int TweetId { set; get; }
        [ForeignKey("Person")]
        public int UserId { set; get; }
        [Required(ErrorMessage = "Enter the message")]
        [MaxLength(140, ErrorMessage = "Message should be 140 characters only")]
        public string Message { set; get; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Created { set; get; }
        public Person Person { set; get; }
    }
}
