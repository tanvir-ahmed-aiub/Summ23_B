using ProductManagement.DB;
using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult All ()
        {
            var db = new UserDBSum23_BEntities();
            var data = db.Products.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new UserDBSum23_BEntities();
            var product = db.Products.Find(id);
            
            return View(Convert(product));
        }
        [HttpPost]
        public ActionResult Edit(ProductDTO pr) { 
            var db = new UserDBSum23_BEntities();
            var exp = db.Products.Find(pr.Id);
            exp.Name = pr.Name;
            exp.Price = pr.Price;
            exp.Qty = pr.Qty;
            exp.Description = pr.Description;
            db.SaveChanges();
            return RedirectToAction("All");
        }
        public ActionResult Delete(int id) { 
            var db = new UserDBSum23_BEntities();
            var expr = db.Products.Find(id);
            db.Products.Remove(expr);
            db.SaveChanges();
            return RedirectToAction("All");

        }
        public ActionResult Add(int id) { 
            var  db = new UserDBSum23_BEntities();
            var pr = db.Products.Find(id);
            var product = Convert(pr);
            product.Qty = 1;
            List<ProductDTO> cart = null;
            if (Session["cart"] != null) {
                cart = (List<ProductDTO>)Session["cart"]; //unboxing
            }
            else
            {
                cart = new List<ProductDTO>();
            }
            cart.Add(product);
            Session["cart"] = cart; //boxing

            TempData["Msg"] = "Product Added to Cart";
            return RedirectToAction("All");
        }
        public ActionResult Cart() {
            var cart = (List<ProductDTO>)Session["cart"];
            if (cart != null) { 
                return View(cart);
            }
            TempData["Msg"] = "Cart is Empty";
            return RedirectToAction("All");

        }
        public ActionResult Checkout() {
            var db = new UserDBSum23_BEntities();
            var order = new Order();
            order.Date = DateTime.Now;
            order.Status = "Ordered";
            var total = 0;
            db.Orders.Add(order);
            var cart = (List<ProductDTO>)Session["cart"];
            foreach (var item in cart) {
                var od = new OrderDetail();
                od.OId = order.Id;
                od.PId = item.Id;
                od.Qty = item.Qty;
                od.Price = item.Price;
                total += item.Qty * item.Price;
                db.OrderDetails.Add(od);

            }
            order.Total = total;
            db.SaveChanges();
            Session["cart"] = null;
            TempData["Msg"] = "Order Placed Successfully with Order Id " + order.Id;
            return RedirectToAction("All");

        }

        public ProductDTO Convert(Product p) {
            var pr = new ProductDTO() { 
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                Description =p.Description
            };
            return pr;
        }
        public Product Convert(ProductDTO p)
        {
            var pr = new Product()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                Description = p.Description
            };
            return pr;
        }
        List<ProductDTO> Convert(List<Product> products) {
            var ps = new List<ProductDTO>();
            foreach (var product in products) {
                var p = Convert(product);
                ps.Add(p);
            }
            return ps;
        }
    }
}