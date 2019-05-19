using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    [Authorize]
    public class NOrderController : Controller
    {
        // GET: NOrder
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var myModel = db.NOrder.ToList();


            if (User.IsInRole("CanManageProducts"))
            {
                return View("AdminIndex", myModel);
            }
            return View("Index", myModel);
        }

        // GET: NOrder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NOrder/Create
        [HttpPost]
        public ActionResult Create(NOrders NOrder)
        {
            if (ModelState.IsValid)
            {
                db.NOrder.Add(NOrder);
                db.SaveChanges();

                return RedirectToAction("Index", "Product");
            }
            else return View();
        }

        // GET: NOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NOrder/Edit/5
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

        // GET: NOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NOrder/Delete/5
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
