using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    public class TitleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Title
        public ActionResult Index()
        {
            var myModel = db.Title.ToList();
            return View(myModel);
        }

        // GET: Title/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Title/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Title/Create
        [HttpPost]
        public ActionResult Create(Titles Title)
        {
            if (ModelState.IsValid)
            {
                db.Title.Add(Title);
                db.SaveChanges();

                return RedirectToAction("Index", "Title");
            }
            else return View();
        }

        // GET: Title/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Title/Edit/5
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

        // GET: Title/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Title/Delete/5
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
