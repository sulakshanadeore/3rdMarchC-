using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CallapiInMVCApp.Models;
using Newtonsoft.Json;

namespace CallapiInMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:50851/api/";

                var json = webClient.DownloadString("Customers");
                List<CustomerViewModel> list = new List<CustomerViewModel>();
                list =JsonConvert.DeserializeObject<List<CustomerViewModel>>(json);
                
                return View(list);
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(string id)
        {

            CustomerViewModel custdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:50851/api/";

                var json = webClient.DownloadString("Customers/" + id);
                
               custdata = JsonConvert.DeserializeObject<CustomerViewModel>(json);
            }
            return View(custdata);

        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerViewModel model)
        {
            try
            {
                
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:50851/api/";
                    var url = "Customers/POST";
                    //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);
                    var response = webClient.UploadString(url, data);
                    JsonConvert.DeserializeObject<CustomerViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(string id)
        {


            CustomerViewModel empdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:50851/api/";

                var json = webClient.DownloadString("Customers/" + id);
                //  var list = emp 
                empdata = JsonConvert.DeserializeObject<CustomerViewModel>(json);
            }
            return View(empdata);

        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, CustomerViewModel model)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:50851/api/Customers/" + id;
                    //var url = "/AJMPD";
                    webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);

                    var response = webClient.UploadString(webClient.BaseAddress, "PUT", data);

                    CustomerViewModel modeldata = JsonConvert.DeserializeObject<CustomerViewModel>(response);

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(string id)
        {
            CustomerViewModel empdata;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "http://localhost:50851/api/";

                var json = webClient.DownloadString("Customers/" + id);
                //  var list = emp 
                empdata = JsonConvert.DeserializeObject<CustomerViewModel>(json);
            }
            return View(empdata);


        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, CustomerViewModel model)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "http://localhost:50851/api/Customers/" + id;
                    //var url = "Customers/Delete";
                    webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string data = JsonConvert.SerializeObject(model);

                    var response = webClient.UploadString(webClient.BaseAddress,"DELETE", data);

                    CustomerViewModel modeldata = JsonConvert.DeserializeObject<CustomerViewModel>(response);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }
    }
}
