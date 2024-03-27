using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCApplicaiton;

namespace MyFirstMVCApplicaiton.Controllers
{
    public class AuditLogsController : Controller
    {
        private MyDBJMAAEntities1 db = new MyDBJMAAEntities1();

        // GET: AuditLogs
        public ActionResult Index()
        {
            //ModelState.AddModelError("Jigar", "user name is duplicate");


            return View(db.AuditLogs.ToList());
        }

        // GET: AuditLogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuditLog auditLog = db.AuditLogs.Find(id);
            if (auditLog == null)
            {
                return HttpNotFound();
            }
            return View(auditLog);
        }

        // GET: AuditLogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuditLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AuditLogId,Text")] AuditLog auditLog)
        {
            if (ModelState.IsValid)
            {
                db.AuditLogs.Add(auditLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auditLog);
        }

        // GET: AuditLogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuditLog auditLog = db.AuditLogs.Find(id);
            if (auditLog == null)
            {
                return HttpNotFound();
            }
            return View(auditLog);
        }

        // POST: AuditLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AuditLogId,Text")] AuditLog auditLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auditLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auditLog);
        }

        // GET: AuditLogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuditLog auditLog = db.AuditLogs.Find(id);
            if (auditLog == null)
            {
                return HttpNotFound();
            }
            return View(auditLog);
        }

        // POST: AuditLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AuditLog auditLog = db.AuditLogs.Find(id);
            db.AuditLogs.Remove(auditLog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
