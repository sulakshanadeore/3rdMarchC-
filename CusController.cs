using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NWLibrary;
using ADONETDEmo.Models;
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
    }
}