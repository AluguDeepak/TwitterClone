using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TwitterCaseStudy.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int UserId { set; get; }
        [Required(ErrorMessage = "Enter Username")]
        [MaxLength(50,ErrorMessage ="Username should be 50 characters")]
        public string Username { set; get; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Password should be 50 characters")]
        public string Password { set; get; }
        [Required(ErrorMessage = "Enter Full Name")]
        [MaxLength(30, ErrorMessage = "Fullname should be 30 characters")]
        public string FullName { set; get; }
        [Required(ErrorMessage = "Enter Email Address")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        public string Email { set; get; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter Join Date")]
        public DateTime Joined { set; get; }
        [Required]
        public bool Active { set; get; }
        public IList<Tweet> Tweets { set; get; }
        public IList<Following> Followings { set; get; }
    }
}
