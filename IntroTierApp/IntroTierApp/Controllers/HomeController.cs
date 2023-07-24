using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroTierApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //data
            var data = StudentService.GetAll();
            return View(data);
        }
        [HttpPost]
        public ActionResult Create() {
            StudentService.CreateStudent(new { });
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