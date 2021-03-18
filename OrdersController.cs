using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStateMgtDemo.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index(int id)
        {
           Session["empid"] = id;
            return View();
        }

        public ActionResult OrderMoreProducts()
        {

            return RedirectToAction("AddToCart", "Products");
        }
    }
}