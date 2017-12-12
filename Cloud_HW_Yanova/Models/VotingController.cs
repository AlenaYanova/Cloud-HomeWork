using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloud_HW_Yanova.Models
{
    public class VotingController : Controller
    {
        // GET: Voting
        public ActionResult Index()
        {
            return View();
        }
        public static string Hello(string UserName) => "Привет, " + UserName + "!";
    }
}