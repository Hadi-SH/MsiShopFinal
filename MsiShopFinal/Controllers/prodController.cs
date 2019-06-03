using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiShopFinal.Controllers
{
    [AllowAnonymous]
    public class ProdController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //// GET: prod
        //[AllowAnonymous]
        //public  ActionResult Index2()
        //{
        //    var myModel = db.Prod.ToList();
        //    return View("Index2", myModel);
        //}


        // GET: prod
        public ActionResult Index()
        {
            var myModel = db.Prod.ToList();

            if (User.IsInRole("CanManageProducts"))
            {
                return View("Index", myModel);
            }
            else if (User.IsInRole("IsReseller"))
            {
                return View("List", myModel);
            }
            else if (User.IsInRole("IsCustomer"))
            {
                return View("List", myModel);
            }
            return View("Index2", myModel);
        }

        //public ActionResult Index()
        //{
        //    List<Prods> myModel = new List<Prods>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        myModel.Add(new Prods
        //        {
        //            SerialNumber = "SerialNumber " + i,
        //            Name = "Name " + i,
        //            Price = i,
        //            Specifications = "Specification " + i,
        //            Image = "img src=@prods.Image" + "style= width:100px ; height: 100px" + i,
        //            CategoryName = "CategoryName" + i
        //        });
        //    }
        //    return View(myModel);
        //}

        //public ActionResult Buy(string serial)
        //{




        //    // 
        //   return RedirectToAction("CreateOrder", "NOrder",serial);

        //}
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
