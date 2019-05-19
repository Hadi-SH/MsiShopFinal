﻿using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    public class ProdController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: prod
        [AllowAnonymous]
        public  ActionResult Index2()
        {
            var myModel = db.Prod.ToList();
            return View("Index2", myModel);
        }


        // GET: prod
        [Authorize]
        public ActionResult Index()
        {
            var myModel = db.Prod.ToList();
            if (User.IsInRole("CanManageProducts"))
            {
                return View("Index", myModel);
            }
            if (User.IsInRole("Reseller"))
            {
                return View("ResIndex", myModel);
            }
            return View("CustIndex", myModel);
        }

        // GET: prod/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: prod/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: prod/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Prods Prod)
        {
            if (ModelState.IsValid)
            {
                db.Prod.Add(Prod);
                db.SaveChanges();

                return RedirectToAction("Index", "Prod");
            }
            else return View();
        }

        // GET: prod/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: prod/Edit/5
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

        // GET: prod/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: prod/Delete/5
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
