using IntrestMvc.Database;
using IntrestMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntrestMvc.Controllers
{
    public class HomeController : Controller
    {
        harshEntities entobj = new harshEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Intrest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Intrest( Test obj)
        {
           var Result = (obj.principle*obj.rate*obj.samay)/100;
            ViewBag.Res = Result;

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}