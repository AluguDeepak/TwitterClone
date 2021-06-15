using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwitterCaseStudy.Models;
namespace TwitterCaseStudy.Context
{
    public class TwitterContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=LAPTOP-6Q7GNNOQ\SQLEXPRESS;Initial Catalog=EFLab3;Integrated Security=True;");
        }
        public DbSet<Person> Persons { set; get; }
        public DbSet<Tweet> Tweets { set; get; }
        public DbSet<Following> Followings { set; get; }
    }
}
