using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cloud_HW_Yanova.Models;

namespace Cloud_HW_Yanova.Models
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelloMessage(string UserName)
        {
            string res = VotingController.Hello(UserName);
             return PartialView((object)res);
        }

        public ActionResult VoteResult()
        {
            string res = "Вы проголосовали за В.В.Путина. Ваш голос очень важен для нас!";
            return PartialView((object)res);
            // ViewData["HelloMassage"] = "Hello " + UserName + "!";
            //return View("Index");
        }
    }
}