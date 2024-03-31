﻿using MyFirstMVCApplicaiton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.Controllers
{

    // Home >> Controller name
    // Idex > Action name

    public class HomeController : Controller
    {

        // State management : 

        // Data store : Client side and server side (Session)


        // EF > ORM >>
        // Approaches >> 1. Database first 2. Code First 3. Model

        // MVC filters : 

        // 1. Authentication filter >> Check my user registerd in my applicaion or not
        // 2. Authorization filter >>  User1 >> Rights >> Roles
        //3 Action filter >> 
        //4. Result filter
        //5 Exception filter




        public ActionResult Index()
        {
            
            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();

            // LINQ  : 

            // how to write LINQ 
            //1. Query Syntax
            //2. Methon Syntax

            // Select * from tablename as a
            //var getData = (from a in myDBJMAAEntities.AUDITTABLEs
            //               select a).ToList();


            //var getDataMethod = myDBJMAAEntities.AUDITTABLEs.ToList();


            // Select *
            //var getDataMethod1 = myDBJMAAEntities.AUDITTABLEs.Select(x => new CustomerModel()
            //{
            //    CustomerID = x.LOGID,
            //    CustomerNameString = x.TEXTData,
            //}).ToList();

            //var getDataQuery = (from a in myDBJMAAEntities.AUDITTABLEs
            //                    select new
            //                    {
            //                        a.LOGID,
            //                        a.TEXTData
            //                    }).ToList();



            int b = 3;



            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            // union
            // union All
            var MS = dataSource1.Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            var MS1223 = dataSource1.Concat(dataSource2).ToList();
            // Result
            //USA
            //"UK"
            //Srilanka

            var MS1 = dataSource2.Intersect(dataSource1).ToList();

            // uk
            //France
            //Japan


            var total = myDBJMAAEntities.Courses.ToList();

            var getDataMethod123 = myDBJMAAEntities.Courses.Where(x => x.CourseId == 1).ToList();

            var getDataMethod1234 = myDBJMAAEntities.Courses.AsEnumerable().Except(getDataMethod123).ToList();






            return View();



            // Projection Operators
            // Select or SelectMany (Homework)

            //Filtering operator
            // Where

            // Partitioning operator
            // Take
            // Skip
            // TakeWhile
            // SKipWhile

            // Ordering operators
            // Orderby
            // OrderbyDesc
            // ThenBy
            // ThenbyDesc
            // Reverse

            // Grouping operators
            // GroupBy

            //Join operators
            // JOin

            // Set operators
            //distinct
            // union
            // Intersect
            // Except

            // Conversation Operator
            // ToList()
            // ToArray()
            // AsEnumrable()

            //Element Operators:
            // First
            // FirstOrDefault()
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt
            // ElementAtOrDefault

            // Quantifier Operators:
            // Any
            // All
            // Contains

            // Aggreegate Operators
            // Sum
            // Min
            // Max.........















            //var a = myDBJMAAEntities.AUDITTABLEs.Where(x => x.LOGID == 1).ToList();

            //// ADD

            //List<AUDITTABLE> aUDITTABLEsList = new List<AUDITTABLE>();

            //AUDITTABLE aUDITTABLEs = new AUDITTABLE();
            //aUDITTABLEs.TEXTData = "JigaR1212121";
            //aUDITTABLEs.ChangeDate = DateTime.Now;
            //aUDITTABLEs.USERNAME = "dbo";
            //aUDITTABLEsList.Add(aUDITTABLEs);

            //AUDITTABLE aUDITTABLEsddd = new AUDITTABLE();
            //aUDITTABLEsddd.TEXTData = "JigaR1212121fdsfdsfsd";
            //aUDITTABLEsddd.ChangeDate = DateTime.Now;
            //aUDITTABLEsddd.USERNAME = "dbo";
            //aUDITTABLEsList.Add(aUDITTABLEsddd);

            ////myDBJMAAEntities.AUDITTABLEs.Add(aUDITTABLEs); // Insert single record
            //myDBJMAAEntities.AUDITTABLEs.AddRange(aUDITTABLEsList); // Multiple record insert hoga

            //myDBJMAAEntities.SaveChanges();


            // ADD

            //var getAUDITTABLEData = myDBJMAAEntities.AUDITTABLEs.Where(x => x.LOGID == 1).FirstOrDefault();
            //getAUDITTABLEData.TEXTData = "JigaRssssss";
            //getAUDITTABLEData.ChangeDate = DateTime.Now;

            //var getAUDITTABLEData123 = myDBJMAAEntities.AUDITTABLEs.Where(x => x.LOGID == 2005).FirstOrDefault();

            //var getAUDITTABLEData1234 = myDBJMAAEntities.AUDITTABLEs.Where(x => x.LOGID == 2004).FirstOrDefault();

            //List<AUDITTABLE> aUDITTABLEsList123 = new List<AUDITTABLE>();

            //aUDITTABLEsList123.Add(getAUDITTABLEData123);
            //aUDITTABLEsList123.Add(getAUDITTABLEData1234);

            //myDBJMAAEntities.AUDITTABLEs.RemoveRange(aUDITTABLEsList123);


            //myDBJMAAEntities.SaveChanges();

            //myDBJMAAEntities.AUDITTABLEs.Add();

            // Select * from AUDITTABLEs where LOGID = 10;



            // LINQ > Lng integrity Query

            // LINQ >> LiNQ TO ENTITY >>>>>>>>>>
            // LINQ >> LiNQ TO Object


            //List<int> ints = new List<int>(); // LiNQ TO Object
            //ints.Add(2);
            //ints.Add(3);

            //var accccc = ints.ToList();



            //// After login > store
            //Session["EmailId"] = "jkigar@gmail.com";


            //HttpCookie cookie = new HttpCookie("MyCookie");
            //cookie.Value = "10";
            //cookie.Expires = DateTime.Now.AddDays(10);
            //this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);


            //TempData["Hello"] = "Helloo Siirrrrr";





            //CustomerModel customerModel = new CustomerModel();
            //customerModel.CustomerNameString = "Jigar Thakkar";
            //customerModel.CheckBox = true;
            //customerModel.CustomerID = 10;
            //ViewBag.CustomerID = 10;
            ////LING
            //ViewBag.users = myDBJMAAEntities.Users.ToList();
            //ViewData["users"] = myDBJMAAEntities.Users.ToList();




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