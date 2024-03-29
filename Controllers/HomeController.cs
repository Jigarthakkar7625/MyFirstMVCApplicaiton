﻿using MyFirstMVCApplicaiton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.Controllers
{

    // Home >> Controller name
    // Idex > Action name

    public class HomeController : Controller
    {

        // State management : 

        // Data store : Client side and server side (Session)


        // MVC filters : 

        // 1. Authentication filter >> Check my user registerd in my applicaion or not
        // 2. Authorization filter >>  User1 >> Rights >> Roles
        //3 Action filter >> 
        //4. Result filter
        //5 Exception filter




        public ActionResult Index() 
        {
          

            // After login > store
            Session["EmailId"] = "jkigar@gmail.com";


            HttpCookie cookie = new HttpCookie("MyCookie");
            cookie.Value = "10";
            cookie.Expires = DateTime.Now.AddDays(10);
            this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);


            TempData["Hello"] = "Helloo Siirrrrr";
            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();
            CustomerModel customerModel = new CustomerModel();
            customerModel.CustomerNameString = "Jigar Thakkar";
            customerModel.CheckBox = true;
            customerModel.CustomerID = 10;
            ViewBag.CustomerID = 10;
            //LING
            ViewBag.users = myDBJMAAEntities.Users.ToList();
            ViewData["users"] = myDBJMAAEntities.Users.ToList();


           return View(customerModel);

            //return RedirectToAction("Index", "Customer"); // Another page ma redirect 
            //return Redirect("About"); // same Controller
        }



        // View(customerModel); >> ViewResult
        // ContentResult() >> 
        // File
        // Redirect and RedirectToAction
        // JSON (JsonResult)
        //Partial VIew


        public FileResult Download(int userID)
        {
            var path = Url.Content("~/Files/" + userID + "/Demo.txt");

            return File(path, "text/plain", "TempFile.txt");

        }


        public ContentResult ContentResultMethod()
        {
            return Content("Hello Brother");
        }



        [HttpPost]
        public ActionResult Index(CustomerModel customerModel1)
        {

            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("MyCookie"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["MyCookie"];


            }
            TempData["Hello"] = "Helloo Siirrrrr";
            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();
            CustomerModel customerModel = new CustomerModel();
            customerModel.CustomerNameString = "Jigar Thakkar";
            customerModel.CheckBox = true;

            ViewBag.users = myDBJMAAEntities.Users.ToList();
            ViewData["users"] = myDBJMAAEntities.Users.ToList();

            //return View(customerModel);

            return RedirectToAction("Index", "Customer");
        }


        [HttpPost]
        public JsonResult GetData(UserModel1 userModel1)
        {

            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();

            var auditLogsList = myDBJMAAEntities.AuditLogs.ToList();

            return Json(auditLogsList, JsonRequestBehavior.AllowGet);

        }


        public PartialViewResult ReturnPartialView()
        {

            CustomerModel customerModel = new CustomerModel();
            customerModel.CustomerNameString = "Hello partial View";

            return PartialView("View", customerModel);
        }

        // How to pass the data Contoller >> View (Viewbag, ViewData)
        // How to pass the data Contoller >> Controller (TempData)

        public ActionResult About()
        {


            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();

            var users = myDBJMAAEntities.Users.ToList(); //Retrive the data from DB

            Student user = new Student();
            user.CourseId = 1;
            user.StudentName = "Jigar";

            myDBJMAAEntities.Students.Add(user);
            myDBJMAAEntities.SaveChanges(); //Save


            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel(){CustomerID = 10,CustomerName=120 },
                new CustomerModel(){CustomerID = 12,CustomerName=1222 },
            };

            TempData["Hello"] = "Helloo Siirrrrr";


            ViewBag.users = users;

            ViewBag.Amount = 10.55;
            ViewBag.IsActive = true;

            ViewBag.UserList = "Hello Jigar";
            ViewBag.Dhruvi = "Hello Dhruvi";



            ViewData["Customers"] = customers;

            ViewData["Amount"] = 10.55;
            ViewData["IsActive"] = true;

            //Type castting

            ViewBag.UserList = "Hello Jigar";
            ViewBag.Dhruvi = "Hello Dhruvi";


            ViewBag.Message = "Your application description page.";

            return View(customers);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

}