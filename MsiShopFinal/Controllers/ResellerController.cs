using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    [Authorize]
    public class ResellerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Reseller
        [Authorize]
        public ActionResult Index()
        {
            var myModel = db.Reseller.ToList();

            if (User.IsInRole("CanManageProducts"))
            {
                return View("Index", myModel);
            }
            return View("ReadOnlyList", myModel);
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
        public async System.Threading.Tasks.Task<ActionResult> CreateAsync(Resellers Reseller)
        {
            if (ModelState.IsValid)
            {
                db.Reseller.Add(Reseller);
                db.SaveChanges();

                //roles
                var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                await roleManager.CreateAsync(new IdentityRole("IsReseller"));
                await UserManager.AddToRoleAsync(Reseller.ResellerId, "IsReseller");

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
