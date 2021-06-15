using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TwitterCaseStudy.Models
{
    [Table("Followers")]
    public class Following
    {
        //[Key]
        //public int FollowerId { set; get; }
        [ForeignKey("Person")]
        public int UserId { set; get; }
        public int FollowingId { set; get; }
        //[ForeignKey("UserId")]
        public Person Person { set; get; }
    }
}
