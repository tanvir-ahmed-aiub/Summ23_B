using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login() {
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username) {
            //ViewBag.Uname = Request["Username"];
            //ViewBag.Uname = form["Username"];
            ViewBag.Uname = Username;
            return View();
        }
        [HttpGet]
        public ActionResult SignUp() {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user) {
            if (ModelState.IsValid) {
                return RedirectToAction("Login");   
            }
            return View(user);   
        }
    }
}