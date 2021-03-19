﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewsExceptionHandingDemo.Models;
namespace PartialViewsExceptionHandingDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {


            //string ans = Add(firstnumber, secondnumber);
            //ViewBag.answer = Convert.ToInt32(TempData["answer"]);
            return View();
        }

        [HandleError]
        [HandleError(ExceptionType =typeof(NullReferenceException),View ="~/Views/Shared/NullReference.cshtml")]
        public ActionResult ShowProducts()
        {
            string data = null;
            ViewBag.msg = data.Length;
            return View();
        }


        public ActionResult ShowData()
        {
            string data = null;
            ViewBag.msg = data.Length;
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Result = RedirectToAction("Error");
            //filterContext.Result = new ViewResult
            //{ ViewName="~/Views/Shared/InternalError.cshtml"};
           // base.OnException(filterContext);
        }
        public ActionResult Error()
        {

            return View("InternalError");
        }

        [HttpPost]
        public ActionResult Index(int firstnumber,int secondnumber)
        {

            string s=Request["name"];
            

            
            //Add(firstnumber,secondnumber);
            
            ViewBag.answer=TempData["answer"];
            return View();
        }
        

        [ChildActionOnly]
        public EmptyResult Add(int firstnumber,int secondnumber)
        {

            Class1 c = new Class1();
            c.firstnumber = firstnumber;
            c.secondnumber = secondnumber;
            TempData["answer"] = c.Addition;
            return new EmptyResult();
            //return PartialView("_Calculator");
        }
    }
}