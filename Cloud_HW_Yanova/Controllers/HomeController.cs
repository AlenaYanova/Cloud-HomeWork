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
        public ActionResult HelloMassage(string UserName)
        {
             string res = "Hello " + UserName + "!";
             return PartialView(res);
           // ViewData["HelloMassage"] = "Hello " + UserName + "!";
            //return View("Index");
        }

        public ActionResult VoteResult()
        {
            string res = "Вы проголосовали за В.В.Путина. Ваш голос очень важен для нас!";
            return PartialView(res);
            // ViewData["HelloMassage"] = "Hello " + UserName + "!";
            //return View("Index");
        }
    }
}