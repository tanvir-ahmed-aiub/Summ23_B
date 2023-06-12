using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult Welcome() {

            string name = "Tanvir Ahmed";
            int count = 36;
            var name2 = new int[] { };
            ViewBag.Name = name;
            ViewBag.Count = count; 
            return View();
        }
        public ActionResult List() {
            //
            string[] names = new string[] { "Raufur","Zaman","Jerin","Safwan","Fardin","Nibal"};
            ViewBag.Names = names;
            return View();
        }
        public ActionResult Login() { 
            return View();
        }
        public ActionResult Submit() {
            //data retreive
            //vilidation
            //authentication
            TempData["Msg"] = "Login Successfull";
            return RedirectToAction("Index","Dashboard");
        }
        
    }
}