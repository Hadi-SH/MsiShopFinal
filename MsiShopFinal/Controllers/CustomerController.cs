﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Customer
        public ActionResult Index()
        {
            var myModel = db.Customer.ToList();



            if (User.IsInRole("CanManageProducts"))
            {
                return View("Index", myModel);
            }
            else if (User.IsInRole("IsCustomer"))
            {
                return View("Index", myModel);
            }
            else if (User.IsInRole("IsResseler"))
            {
                return View("ROL", myModel);
            }
            return View("ROL", myModel);
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
        [Authorize]
        public ActionResult Create(Customers Customer)
        {
            if (ModelState.IsValid)
            {
                db.Customer.Add(Customer);
                db.SaveChanges();

                //roles
                //var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                //var roleManager = new RoleManager<IdentityRole>(roleStore);
                //await roleManager.CreateAsync(new IdentityRole("Customer"));
                //await UserManager.AddToRoleAsync(Customer.CustomerId, "Customer");

                return RedirectToAction("Index", "Customer");
            }
            else return View();

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
