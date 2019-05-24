using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //GET: Category
        //public ActionResult Index()
        //{
        //    var myModel = db.Category.ToList();
        //    return View(myModel);
        //}

        public ActionResult Index()
        {
            var myModel = db.Category.ToList();


            //if (User.IsInRole("CanManageProducts"))
            //{
            //    return View("Index",myModel);
            //}
            //return View("Prvlgs",myModel);
            return View("Index", myModel);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Categorys Category)
        {
            if (ModelState.IsValid)
            {
                db.Category.Add(Category);
                db.SaveChanges();

                return RedirectToAction("Index", "Category");
            }
            else return View();
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            //var category = db.Category.SingleOrDefault(c => c.Id == id);

            //if (category == null)
            //    return HttpNotFound();
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
