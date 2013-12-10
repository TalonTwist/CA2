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
        private NorthwindEntities2 nwdb = new NorthwindEntities2();
        
   
        protected override void Dispose(bool disposing)
        {
            nwdb.Dispose();
        }

        //
        // GET: /Home/

        public ActionResult Index(string searchTerm)
        {
            var allArtists = nwdb.Orders.Include(i => i.Customer);
            return View(allArtists);
        }

        //
        // GET: /Home/Albums/5
        
        public PartialViewResult Details(int id = 1)
        {
            Employee employee = nwdb.Employees.Find(id);
            return PartialView("Employee", employee);
        }

        public ActionResult Employee_orders(int id = 1)
        {
            var orders = nwdb.Orders.Where(o => o.EmployeeID == id || id == 1);

            int pageSize = 10;
            int pageNumber = 1;

            return View(orders.ToPagedList(pageSize, pageNumber));
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
            Order order = nwdb.Orders.Find(id);

            return View(order);
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
