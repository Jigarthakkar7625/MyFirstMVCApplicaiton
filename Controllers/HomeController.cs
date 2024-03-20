using MyFirstMVCApplicaiton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.Controllers
{

    // Home >> Controller name
    // Idex > Action name

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["Hello"] = "Helloo Siirrrrr";
            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();
            CustomerModel customerModel = new CustomerModel();
            customerModel.CustomerNameString = "Jigar Thakkar";
            customerModel.CheckBox = true;

            ViewBag.users = myDBJMAAEntities.Users.ToList();
            ViewData["users"] = myDBJMAAEntities.Users.ToList();

            return View(customerModel);

            //return RedirectToAction("Index", "Customer");
        }
        [HttpPost]
        public ActionResult Index(CustomerModel customerModel1)
        {
            TempData["Hello"] = "Helloo Siirrrrr";
            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();
            CustomerModel customerModel = new CustomerModel();
            customerModel.CustomerNameString = "Jigar Thakkar";
            customerModel.CheckBox = true;

            ViewBag.users = myDBJMAAEntities.Users.ToList();
            ViewData["users"] = myDBJMAAEntities.Users.ToList();

            return View(customerModel);

            //return RedirectToAction("Index", "Customer");
        }

        // How to pass the data Contoller >> View (Viewbag, ViewData)
        // How to pass the data Contoller >> Controller (TempData)

        public ActionResult About()
        {


            MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();

            var users = myDBJMAAEntities.Users.ToList(); //Retrive the data from DB

            Student user = new Student();
            user.CourseId = 1;
            user.StudentName= "Jigar";

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