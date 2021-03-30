using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NWLibrary;
using WebApiDemo.Models;
namespace WebApiDemo.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/<controller>
        CustomersDAL dal = new CustomersDAL();
        public IEnumerable<CustomerModel> Get()
        {
            
            List<Customers> custlist = new List<Customers>();
                 custlist=dal.GetCustomers();
            List<CustomerModel> custmodels = new List<CustomerModel>();
            foreach (var item in custlist)
            {
                CustomerModel model = new CustomerModel();
                model.CompanyName = item.CompanyName;
                model.Custid = item.CustId;
                model.City=item.City;
                custmodels.Add(model);
            }
            return custmodels;
        }

        // GET api/<controller>/5
        public CustomerModel Get(string id)
        {
            Customers customers=dal.GetCustomersByID(id);
            CustomerModel model = new CustomerModel();
            model.Custid = customers.CustId;
            model.CompanyName = customers.CompanyName;
            model.City = customers.City;
            return model;
                
        }

        // POST api/<controller>
        public void Post([FromBody]CustomerModel value)
        {
            Customers customers = new Customers();
            customers.CustId = value.Custid;
            customers.CompanyName = value.CompanyName;
            customers.City = value.City;

            dal.InsertCustomer(customers);

        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]CustomerModel value)
        {
            Customers customers = new Customers();
            customers.CustId = id;
            customers.CompanyName = value.CompanyName;
            customers.City = value.City;
           dal.EditCustomer(customers);

        }

        // DELETE api/<controller>/5
        public void Delete(string id)
        {
            dal.Delete(id);
        }
    }
}