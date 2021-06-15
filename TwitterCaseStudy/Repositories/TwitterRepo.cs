using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterCaseStudy.Models;
using TwitterCaseStudy.Context;
namespace TwitterCaseStudy.Repositories
{
    public class TwitterRepo : ITwitterRepo
    {
        private TwitterContext db = null;
        public TwitterRepo()
        {
            db = new TwitterContext();
        }

        public void AddTweet(Tweet tweet)
        {
            db.Tweets.Add(tweet);
            db.SaveChanges();
        }

        public void AddUser(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }

        public List<Tweet> GetAllTweets()
        {
            return db.Tweets.ToList();
        }

        public Person GetUserDetail(string uname, string pwd)
        {
            Person person = db.Persons.SingleOrDefault(i => i.Username == uname && i.Password == pwd);
            return person;
        }

        public bool ValidateUser(string uname, string pwd)
        {
            //person = db.Persons.SingleOrDefault(i => i.Username == uname && i.Password == pwd);
            int j=(from i in db.Persons where i.Username == uname && i.Password == pwd select i.UserId).Count();
            if (j==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
