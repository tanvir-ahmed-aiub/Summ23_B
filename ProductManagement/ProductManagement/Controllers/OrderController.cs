using ProductManagement.Auth;
using ProductManagement.DB;
using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [AdminAccess]
        public ActionResult Index()
        {
            
            var db = new UserDBSum23_BEntities();
            var orders = db.Orders.ToList();
            return View(Convert(orders));
        }
        [AdminAccess]
        public ActionResult Details(int id) {
            var db = new UserDBSum23_BEntities();
            var od = db.Orders.Find(id);
            //temporay using db instance instead of DTO

            return View(od);
        }
        [AdminAccess]
        public ActionResult Process(int id) {
            var db = new UserDBSum23_BEntities();
            var od = db.Orders.Find(id);
            foreach (var item in od.OrderDetails) { 
                var p = db.Products.Find(item.PId);
                p.Qty -= item.Qty;             
            }
            od.Status = "Processing";
            db.SaveChanges();
            TempData["Msg"] = "Order Id " + id + " started Processing";
            return RedirectToAction("Index");

        }
        [AdminAccess]
        public ActionResult Decline(int id) {
            var db = new UserDBSum23_BEntities();
            var od = db.Orders.Find(id);
            od.Status = "Declined";
            db.SaveChanges();
            TempData["Msg"] = "Order " + od.Id + " is Declined";
            return RedirectToAction("Index");
        }
        
        OrderDTO Convert(Order o) {
            var od = new OrderDTO() { 
                Id = o.Id,
                Date = o.Date,
                Status = o.Status,
                Total = o.Total
            };
            return od;
        }
        Order Convert(OrderDTO o) {
            var od = new Order()
            {
                Id = o.Id,
                Date = o.Date,
                Status = o.Status,
                Total = o.Total
            };
            return od;
        }
        List<OrderDTO> Convert(List<Order> orders) {
            var ods = new List<OrderDTO>();
            foreach (var o in orders) { 
                ods.Add(Convert(o));
            }
            return ods;
        }
    }
}