using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstWebApplication.Models;

namespace MVCFirstWebApplication.Controllers
{
    public class CustomersController : Controller
    {
        static List<Cust> mycustlist = new List<Cust>();
        // GET: Customers
        public ViewResult ListCustomers()
        {
            mycustlist.Add(new Cust {CustomerID=1,CustomerName="Bina",CustomerCity="Bangalore" });

            mycustlist.Add(new Cust { CustomerID = 2, CustomerName = "Mina", CustomerCity = "Hyderabad" });

            mycustlist.Add(new Cust { CustomerID = 3, CustomerName = "Rina", CustomerCity = "Pune" });
                       
            return View(mycustlist);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cust cust)
        {
            mycustlist.Add(cust);

            return RedirectToAction("ListCustomers");
        }

        public ActionResult EditCustomer(int id)
        {
            Cust foundCustomer = mycustlist.Find(a => a.CustomerID == id);


            return View(foundCustomer);
        }

        [HttpPost]
        public ActionResult EditCustomer(int id, Cust custedited)
        {
            Cust foundCustomer = mycustlist.Find(a => a.CustomerID == id);
            foundCustomer.CustomerName = custedited.CustomerName;
            foundCustomer.CustomerCity = custedited.CustomerCity;

            return RedirectToAction("ListCustomers");
        }

        
        public ActionResult DeleteCustomer(int id)
        {
            Cust foundCustomer = mycustlist.Find(a => a.CustomerID == id);

            return View(foundCustomer);
        }

        [HttpPost]
        public ActionResult DeleteCustomer(int id,Cust c)
        {
            Cust foundCustomer = mycustlist.Find(a => a.CustomerID == id);
            mycustlist.Remove(foundCustomer);
            return Content("Deleted the customer id " + id);
        }

        //public JsonResult ActionName()
        //{

        //    return View();
        //}

        //public ContentResult ActionName()
        //{

        //    string s = "Hello";
        //    return ContentResult(s);
        //}


    }
}