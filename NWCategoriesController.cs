using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebapiCallUsingHttpClientDemo.Models;

namespace WebapiCallUsingHttpClientDemo.Controllers
{
    public class NWCategoriesController : Controller
    {
        // GET: NWCategories
        public ActionResult Index()
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58272/api/");
                var task = client.GetAsync("Categories");
                //the getasync() is asynchronous and returns a task.
                //The Task.wait() suspends the execution until getasync() completes the execution and returns the result.
                task.Wait();
                var result = task.Result;//returns httpresponseMessage
                if (result.IsSuccessStatusCode)//200 OK
                {
                    var readData = result.Content.ReadAsAsync<CategoryModel[]>();
                    readData.Wait();
                    
                 categories=readData.Result.ToList();
                    
                      
                }

            }
            

            return View(categories);
        }

        // GET: NWCategories/Details/5
        public ActionResult Details(int id)
        {
            CategoryModel cm = new CategoryModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58272/api/");
                var task = client.GetAsync("Categories/" + id);
                //the getasync() is asynchronous and returns a task.
                //The Task.wait() suspends the execution until getasync() completes the execution and returns the result.
                task.Wait();
                var result = task.Result;//returns httpresponseMessage
                if (result.IsSuccessStatusCode)//200 OK
                {
                    var readData = result.Content.ReadAsAsync<CategoryModel>();
                    readData.Wait();

                    cm = readData.Result;


                }

            }

            return View(cm);
        }

        // GET: NWCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NWCategories/Create
        [HttpPost]
        public ActionResult Create(CategoryModel model)
        {
            try
            {
                // TODO: Add insert logic here
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:58272/api/Categories");
                    var postTask = client.PostAsJsonAsync<CategoryModel>("Categories", model);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readtask = result.Content.ReadAsAsync<CategoryModel>();
                        readtask.Wait();
                        var insertedcategory = readtask.Result;
                    }
                }
                
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: NWCategories/Edit/5
        public ActionResult Edit(int id)
        {
            CategoryModel cm = new CategoryModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58272/api/");
                var task = client.GetAsync("Categories/" + id);
                //the getasync() is asynchronous and returns a task.
                //The Task.wait() suspends the execution until getasync() completes the execution and returns the result.
                task.Wait();
                var result = task.Result;//returns httpresponseMessage
                if (result.IsSuccessStatusCode)//200 OK
                {
                    var readData = result.Content.ReadAsAsync<CategoryModel>();
                    readData.Wait();

                    cm = readData.Result;


                }

            }

            return View(cm);
        }

        // POST: NWCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CategoryModel model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:58272/api/");
                    var postTask = client.PutAsJsonAsync<CategoryModel>("Categories/" + id,model);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readtask = result.Content.ReadAsAsync<CategoryModel>();
                        readtask.Wait();
                        var updatedcategory = readtask.Result;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NWCategories/Delete/5
        public ActionResult Delete(int id)
        {

            CategoryModel cm = new CategoryModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58272/api/");
                var task = client.GetAsync("Categories/" + id);
                //the getasync() is asynchronous and returns a task.
                //The Task.wait() suspends the execution until getasync() completes the execution and returns the result.
                task.Wait();
                var result = task.Result;//returns httpresponseMessage
                if (result.IsSuccessStatusCode)//200 OK
                {
                    var readData = result.Content.ReadAsAsync<CategoryModel>();
                    readData.Wait();

                    cm = readData.Result;


                }

            }

            return View(cm);
        }

        // POST: NWCategories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CategoryModel model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:58272/api/");
                    var postTask = client.DeleteAsync("Categories/" + id);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readtask = result.Content.ReadAsAsync<CategoryModel>();
                        readtask.Wait();
                        var updatedcategory = readtask.Result;
                    }
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
