using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    public class ResellerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Reseller
        [Authorize]
        public ActionResult Index()
        {
            var myModel = db.Reseller.ToList();
            return View(myModel);
        }

        // GET: Reseller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reseller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reseller/Create
        [HttpPost]
        public ActionResult Create(Resellers Reseller)
        {
            if (ModelState.IsValid)
            {
                db.Reseller.Add(Reseller);
                db.SaveChanges();

                return RedirectToAction("Index", "Reseller");
            }
            else return View();
        }

        // GET: Reseller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reseller/Edit/5
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

        // GET: Reseller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reseller/Delete/5
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
