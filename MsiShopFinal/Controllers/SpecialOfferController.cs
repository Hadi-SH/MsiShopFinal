using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    [Authorize]
    public class SpecialOfferController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: SpecialOffer
        public ActionResult Index()
        {
            var myModel = db.SpecialOffer.ToList();


            if (User.IsInRole("CanManageProducts"))
            {
                return View("Index", myModel);
            }
            return View("ReadOnlyList", myModel);
        }

        // GET: SpecialOffer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SpecialOffer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SpecialOffer/Create
        [HttpPost]
        public ActionResult Create(SpecialOffers SpecialOffer)
        {
            if (ModelState.IsValid)
            {
                db.SpecialOffer.Add(SpecialOffer);
                db.SaveChanges();

                return RedirectToAction("Index", "SpecialOffer");
            }
            else return View();
        }

        // GET: SpecialOffer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SpecialOffer/Edit/5
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

        // GET: SpecialOffer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SpecialOffer/Delete/5
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
