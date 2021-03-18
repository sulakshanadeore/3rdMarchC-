using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStateMgtDemo.Models;

namespace MVCStateMgtDemo.Controllers
{
    public class ProductsController : Controller
    {
        static List<Product> orders = new List<Product>();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(Product product,int empid)
        {
            orders.Add(product);
            TempData["productorders"] = orders;
            // return RedirectToAction("Index", "Orders");

            return RedirectToAction("Index", "Orders", new { id = empid });
        }
    }
}