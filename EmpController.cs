using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NWLibrary;
using ADONETDEmo.Models;
using System.Data;

namespace ADONETDEmo.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult ShowEmployeeIDGreaterThan5()
        {
            EmployeeDAL dal = new EmployeeDAL();
            DataView dv=dal.FilterByCity();
            List<EmployeeModel> emplist = new List<EmployeeModel>();
            for (int i = 0; i < dv.Count; i++)
            {
                EmployeeModel em = new EmployeeModel();
                em.Empid = Convert.ToInt32(dv[i].Row[0]);
                em.Fname = dv[i].Row[1].ToString();
                em.Lname = dv[i].Row[2].ToString();
                emplist.Add(em);
            }
            return View(emplist);
        }



        public ActionResult Index()
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            List<Employees> emplist=employeeDAL.GetEmployees();

            List<EmployeeModel> modelList = new List<EmployeeModel>();
            foreach (var item in emplist)
            {
                EmployeeModel model = new EmployeeModel();
                model.Empid = item.Empid;
                model.Fname = item.Fname;
                model.Lname = item.Lname;
                modelList.Add(model);

            }

            return View(modelList);
        }


        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            Employees emp = new Employees();
            emp.Fname = model.Fname;
            emp.Lname = model.Lname;
            employeeDAL.InsertEmployee(emp);
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id,EmployeeModel empdata)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            Employees emp = new Employees();
            emp.Empid = id;
            emp.Fname = empdata.Fname;
            emp.Lname = empdata.Lname;

            employeeDAL.UpdateEmployee(emp);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            Employees emp=employeeDAL.GetEmployeeById(id);
            EmployeeModel model = new EmployeeModel();
            model.Empid = emp.Empid;
            model.Fname = emp.Fname;
            model.Lname = emp.Lname;

            return View(model);
        }

    }
}