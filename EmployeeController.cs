using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStateMgtDemo.Models;

namespace MVCStateMgtDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [OutputCache(CacheProfile = "cacheprofile1")]
        public ActionResult Index()
        {
            ViewBag.pagetime=DateTime.Now.ToLongTimeString();
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
           return     RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult EditEmployee()
        {

            return View();
        }

    }
}