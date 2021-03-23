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
    public class CusController : Controller
    {


        public ActionResult Edit(string id)
        {
            CustomersDAL customersDAL = new CustomersDAL();
            Customers c=customersDAL.GetCustomersByID(id);
            CustomerModel cm = new CustomerModel();
            cm.CustId = c.CustId;
            cm.CompanyName = c.CompanyName;
            return View(cm);
        }
        [HttpPost]
        public ActionResult Edit(string id,CustomerModel c)
        {
            CustomersDAL customersDAL = new CustomersDAL();
            Customers c1 = new Customers();
            c1.CustId = c.CustId;
            c1.CompanyName = c.CompanyName;
            customersDAL.EditCustomer(c1);
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            CustomersDAL dal = new CustomersDAL();
            Customers c=dal.GetCustomersByID(id);
            CustomerModel cm = new CustomerModel();
            cm.CustId = c.CustId;
            cm.CompanyName = c.CompanyName;

            return View(cm);
        }

        public ActionResult Delete(string id)
        {
            CustomersDAL dal = new CustomersDAL();
            Customers c = dal.GetCustomersByID(id);
            CustomerModel cm = new CustomerModel();
            cm.CustId = c.CustId;
            cm.CompanyName = c.CompanyName;
            return View(cm);
        }
        [HttpPost]
        public ActionResult Delete(string id,CustomerModel cm)
        {
            CustomersDAL dal = new CustomersDAL();
            dal.Delete(id);
            return RedirectToAction("Index");
        }



        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerModel model)
        {
            CustomersDAL customersDAL = new CustomersDAL();
            Customers c = new Customers();
            c.CustId = model.CustId;
            c.CompanyName = model.CompanyName;
            customersDAL.InsertCustomer(c);

            return RedirectToAction("Index");

        }



        // GET: Cus
        public ActionResult Index()
        {
            CustomersDAL dal = new CustomersDAL();
            List<Customers> custs=dal.GetCustomers();
            List<CustomerModel> custmodels = new List<CustomerModel>();
            foreach (var item in custs)
            {
                CustomerModel cm = new CustomerModel();
                cm.CustId = item.CustId;
                cm.CompanyName = item.CompanyName;
                custmodels.Add(cm);
            }

            return View(custmodels);
        }

        
        public ActionResult FilterByCity()
        {
            string city = TempData["city"].ToString();
            List<CustomerModel> custlist = CallData(city);
            return View(custlist);
        }

        [ChildActionOnly]
        private static List<CustomerModel> CallData(string city)
        {
            List<CustomerModel> custlist = new List<CustomerModel>();
            CustomersDAL dal = new CustomersDAL();
            DataTable dt = new DataTable();
            dt = dal.FilterByCity(city);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CustomerModel cm = new CustomerModel();
                cm.CustId = dt.Rows[i][0].ToString();
                cm.CompanyName = dt.Rows[i][1].ToString();
                cm.City = dt.Rows[i][5].ToString();
                custlist.Add(cm);
            }

            return custlist;
        }

        public ActionResult ShowCityList()
        {
            CustomersDAL dal = new CustomersDAL();
            List<string> citylist = new List<string>();
            citylist=dal.ShowAllCities();
            ViewBag.cities = citylist;
            return View();
        }

        [HttpPost]
        public ActionResult ShowCityList(string city)
        {
            //List<CustomerModel> custlist = new List<CustomerModel>();
            //CustomersDAL dal = new CustomersDAL();
            //DataTable dt = new DataTable();
            //dt = dal.FilterByCity(city);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    CustomerModel cm = new CustomerModel();
            //    cm.CustId = dt.Rows[i][0].ToString();
            //    cm.CompanyName = dt.Rows[i][1].ToString();
            //    cm.City = dt.Rows[i][5].ToString();
            //    custlist.Add(cm);
            //}
            //return View(custlist);
            TempData["city"] = city;
            return RedirectToAction("FilterByCity");

        }





    }
}