using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterCaseStudy.Models;
using TwitterCaseStudy.Repositories;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
namespace TwitterCaseStudy.Controllers
{
    public class TwitterController : Controller
    {
        private TwitterRepo repo = null;
        public TwitterController()
        {
            repo = new TwitterRepo();
        }
        public IActionResult Dashboard()
        { 
            Person person= repo.GetUserDetail(HttpContext.Session.GetString("Username"), HttpContext.Session.GetString("Password"));
            HttpContext.Session.SetInt32("UserId", person.UserId);
            ViewBag.fullname = person.FullName;
            List<Tweet> tweets = repo.GetAllTweets();
            ViewData["count"] = 0;
            return View(tweets);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            repo.AddUser(person);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            if (repo.ValidateUser(uname, pwd))
            {
                HttpContext.Session.SetString("Username", uname);
                HttpContext.Session.SetString("Password", pwd);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Error = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Profile()
        {
            Person person = repo.GetUserDetail(HttpContext.Session.GetString("Username"), HttpContext.Session.GetString("Password"));
            return View(person);
        }
        public IActionResult Signout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        [HttpPost]
        public IActionResult PostTweet(string message)
        {
            Tweet tweet = new Tweet()
            {
                Message = message,
                Created = DateTime.Now,
                UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"))
            };
            repo.AddTweet(tweet);
            return RedirectToAction("Dashboard");
        }
    }
}
