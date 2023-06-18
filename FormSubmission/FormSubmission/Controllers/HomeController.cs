using FormSubmission.Db;
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
        public ActionResult Index() {
            var db =new UserDBSum23_BEntities();
            var users = db.Users.ToList();
            return View(Convert(users));
        }
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
        public ActionResult SignUp(UserDTO user) {
            if (ModelState.IsValid) {
                var db = new UserDBSum23_BEntities();
                db.Users.Add(Convert(user));
                db.SaveChanges();
                return RedirectToAction("Index");
                //return RedirectToAction("Login");   

            }
            return View(user);   
        }

        User Convert(UserDTO user) {
            var u = new User()
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                Profession=user.Profession,
                Gender = user.Gender,
            };
            return u;
        }
        UserDTO Convert(User user) {
            var u = new UserDTO()
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                Profession = user.Profession,
                Gender = user.Gender,
            };
            return u;
        }
        List<UserDTO> Convert(List<User> users) {
            var urs = new List<UserDTO>();
            foreach (var item in users) { 
                urs.Add(Convert(item));
            }
            return urs;
        }




        

    }
}