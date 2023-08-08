using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cat = CategoryService.Get(1);
            return View(cat);
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