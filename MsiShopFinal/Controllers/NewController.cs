using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    public class NewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: New
        public ActionResult Index()
        {
            var myModel = db.New.ToList();
            return View(myModel);
        }

        // GET: New/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: New/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: New/Create
        [HttpPost]
        public ActionResult Create(News New)
        {
            if (ModelState.IsValid)
            {
                db.New.Add(New);
                db.SaveChanges();

                return RedirectToAction("Index", "New");
            }
            else return View();
        }

        // GET: New/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: New/Edit/5
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

        // GET: New/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: New/Delete/5
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