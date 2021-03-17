using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstWebApplication.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ContentResult Index(string productname)
        {

            return Content("U have ordered " + productname);
        }
    }
}