using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyDoAn.Models;

namespace QuanLyDoAn.Areas.Admins.Controllers
{
    public class Account_AdController : Controller
    {
        private QLDADbContext db = new QLDADbContext();
        StringProcess strPro = new StringProcess();

        // GET: Admins/Account_Ad
        public ActionResult Index()
        {
            return View(db.Accounts.ToList());
        }

        // GET: Admins/Account_Ad/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounts accounts = db.Accounts.Find(id);
            if (accounts == null)
            {
                return HttpNotFound();
            }
            return View(accounts);
        }

        // GET: Admins/Account_Ad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Account_Ad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserName,Password,ConfirmPassWord,Email,CreationTime,EmailConfirmed,IsDelete,DeleteTime,RoleID")] Accounts accounts)
        {
            accounts.CreationTime = DateTime.Now;
            accounts.EmailConfirmed = false;
            accounts.IsDelete = false;
            string strMD5 = strPro.GetMD5(accounts.Password);
            if (accounts.Password == accounts.ConfirmPassWord)
            {
                accounts.Password = strMD5;
                accounts.ConfirmPassWord = strMD5;
            }

            if (ModelState.IsValid)
            {
                db.Accounts.Add(accounts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accounts);
        }

        // GET: Admins/Account_Ad/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounts accounts = db.Accounts.Find(id);
            if (accounts == null)
            {
                return HttpNotFound();
            }
            return View(accounts);
        }

        // POST: Admins/Account_Ad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserName,Password,ConfirmPassWord,Email,CreationTime,EmailConfirmed,IsDelete,DeleteTime,RoleID")] Accounts accounts)
        {
            string strMD5 = strPro.GetMD5(accounts.Password);
            if (accounts.Password == accounts.ConfirmPassWord)
            {
                accounts.Password = strMD5;
                accounts.ConfirmPassWord = strMD5;
            }

            if (ModelState.IsValid)
            {
                db.Entry(accounts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounts);
        }

        // GET: Admins/Account_Ad/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounts accounts = db.Accounts.Find(id);
            if (accounts == null)
            {
                return HttpNotFound();
            }
            return View(accounts);
        }

        // POST: Admins/Account_Ad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Accounts accounts = db.Accounts.Find(id);
            db.Accounts.Remove(accounts);
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
