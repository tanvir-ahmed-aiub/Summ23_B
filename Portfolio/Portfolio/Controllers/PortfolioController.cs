using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            ViewBag.Name = "Tanvir";
            ViewBag.Contact = "tanvir.ahmed@aiub.edu";
            ViewBag.Bio = "Bio";
            return View();
        }
        public ActionResult Profile() {
            var profile = new MyProfile();
            profile.Name = "Tanvir Ahmed";
            profile.Email = "ff";
            profile.Dob = "12.12.1.2";
            profile.Address = "Dhaka";
            profile.Contact = "3446";
            profile.Hobbies = new string[] { "Travelling","Sports"};

            return View(profile);
        }
        public ActionResult Education() {
            MyEducation edu1 = new MyEducation();
            edu1.Degree = "BSc";
            edu1.Year = "2023";
            edu1.Ins = "AIUB";

            MyEducation edu2 = new MyEducation();
            edu2.Year = "2021";
            edu2.Degree = "HSC";
            edu2.Ins = "Dhaka";

            MyEducation edu3 = new MyEducation();
            edu3.Year = "2019";
            edu3.Degree = "SSC";
            edu3.Ins = "Dhaka";

            MyEducation[] myEducations = new MyEducation[] {edu1, edu2, edu3 };

            ViewBag.Edus = myEducations;
            return View();
        }
        public ActionResult Projects() {
            var p1 = new MyProject();
            p1.Course = "WT";
            p1.Description = "MS";

            var p2 = new MyProject();
            p2.Course = "OOP2";
            p2.Description = "MS";

            var projects = new MyProject[] { p1, p2 };
            return View(projects);
        }
        public ActionResult References() {
            return View();
        }
    }
}