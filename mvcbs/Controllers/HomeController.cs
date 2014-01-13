using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace mvcbs_music
{
    public class HomeController : Controller
    {
        //private NorthwindEntities2 nwdb = new NorthwindEntities2();
        private NwEntities Nw = new NwEntities();
        
   
        protected override void Dispose(bool disposing)
        {
            Nw.Dispose();
        }

        //
        // GET: /Home/

        public ActionResult Index(string searchTerm)
        {
            var allProducts = Nw.Products;
            return View(allProducts);
        }

        //
        // GET: /Home/Albums/5
        
        public PartialViewResult Details(int id = 1)
        {
            Order order = Nw.Orders.Find(id);
            return PartialView("Orders", order);
        }

        
        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            Product product = Nw.Products.Find(id);

            return View(product);
        }

        //
        // POST: /Home/Delete/5

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
