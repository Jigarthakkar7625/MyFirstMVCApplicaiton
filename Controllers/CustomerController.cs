using MyFirstMVCApplicaiton.AuthData;
using MyFirstMVCApplicaiton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplicaiton.Controllers
{
    //[Authorization("Admin")]
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Login()
        {

            Session["Roles"] = "Admin"; // Will come from Database

            //User 
            // 1 

            // UserRole
            //1,"Admin",1
             //2,"HR",1


            //var userid = Session["UserId"].ToString();
            // Client side >> 

            //Hidden FIeld
            //Cookie
            //QueryString
            //VIewdata, ViewBag and tempData

            //URL?id=10&firstName=jigar&lastName=thakkar
            // VIewdata, ViewBag and tempData

            //var id = Request.QueryString["Id"].ToString();
            //var firstName = Request.QueryString["firstName"].ToString();
            //var lastName = Request.QueryString["lastName"].ToString();

           CustomerModel customerModel = new CustomerModel();
            //customerModel.CustomerID = 10;
            //customerModel.CustomerName = 125;


            //if (TempData.ContainsKey("Hello"))
            //{
            //    var abc = TempData["Hello"].ToString();
            //    TempData.Keep();
            //}

           

            return View(customerModel);
        }

     

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
