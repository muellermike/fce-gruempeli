using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FceGruempeli.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Gruempi()
        {
            return View();
        }

        public ActionResult School()
        {
            return View();
        }

        public ActionResult Rules()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RankingList()
        {
            return View();
        }

    }
}