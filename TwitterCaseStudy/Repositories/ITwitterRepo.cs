using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterCaseStudy.Models;
namespace TwitterCaseStudy.Repositories
{
    interface ITwitterRepo
    {
        void AddUser(Person person);
        bool ValidateUser(string uname, string pwd);
        Person GetUserDetail(string uname, string pwd);
        List<Tweet> GetAllTweets();
        void AddTweet(Tweet tweet);
    }
}
