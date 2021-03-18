using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStateMgtDemo.Models;
namespace MVCStateMgtDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["message"] = "HelloWorld";
            //ViewData["message"] = null;

            Employee emp = new Employee();
            emp.Empid = 1;
            emp.Empname = "Ashwini";

            ViewData["empdata"] = emp;

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Empid=1,Empname="Ashwini"});
            emplist.Add(new Employee { Empid = 2, Empname = "Aishwarya" });
            emplist.Add(new Employee { Empid = 3, Empname = "Rutuja" });

            ViewData["myemplist"] = emplist;
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id)
        {

            return RedirectToAction("About");
        }



        public ActionResult About()
        {


            ViewBag.Message = "Your application description page.";

            ViewBag.greet = "HelloWorld";
            //ViewBag["message"] = null;

            Employee emp = new Employee();
            emp.Empid = 1;
            emp.Empname = "Ashwini";

            ViewBag.empdata = emp;

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Empid = 1, Empname = "Ashwini" });
            emplist.Add(new Employee { Empid = 2, Empname = "Aishwarya" });
            emplist.Add(new Employee { Empid = 3, Empname = "Rutuja" });

            ViewBag.myemplist = emplist;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Action1()
        {

            TempData["morningMessage"] = "Good morning";
            return RedirectToAction("Action2");
        }

        public ActionResult Action2()
        {
            TempData.Keep();
            return View();
        }

        [HttpPost]
        public ActionResult Action2(int id)
        {

            TempData.Keep();
            return RedirectToAction("Action3");
        }

        public ActionResult Action3()
        {
            var data= TempData.Peek("morningMessage");
            TempData["morningMessage"] = data;
                
            return View();
        }


    }
}