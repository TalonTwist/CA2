using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcbs_music.Controllers
{
    public class AlbumController : Controller
    {
        private NorthwindEntities nwdb = new NorthwindEntities();

        protected override void Dispose(bool disposing)
        {
            nwdb.Dispose();
        }

        //
        // GET: /Album/

        public ActionResult Index(int id = 0)
        {
            // .Single() will fail (exception) if >1 row returned
            // .SingleOrDefault() will return null if nothing retreived
            //var albumQuery = db.Albums.SingleOrDefault(al => al.AlbumId == id);
            //if (albumQuery != null)
            //{
            //    return View(new List<Album>{albumQuery});
            //}
            return View();
        }

        public ActionResult IndexArtist(int id)
        {
           // Show artist and associated albums
            //var chosenArtist = db.Artists.SingleOrDefault(art => art.ArtistId == id);
            //if (chosenArtist != null)
            //{
            //    if (chosenArtist.Albums.Count > 0)
            //    {
            //        ViewBag.Message =
            //        String.Format("Albums for <span class='strong text-info'>{0}</span>", 
            //            chosenArtist.Name);
            //        return View("ArtistNAlbums", chosenArtist);
            //    }
            //    else
            //    {
            //        ViewBag.Message = "No Albums for this Artist";
            //        TempData["ErrMsg"] = "No Albums for this Artist";
            //    }
            //}
            //ViewBag.Message = "Artist not known";
            //TempData["ErrMsg"] = "Showing all Albums";
            return RedirectToAction("Index");
        }

        //
        // GET: /Album/Details/5

        public ActionResult Details(int id)
        {
            //var selectedAlbum = db.Albums.First(a => a.AlbumId == id);
            //return View(selectedAlbum);

            return View();
        }

        //
        // GET: /Album/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Album/Create

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
        // GET: /Album/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Album/Edit/5

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
        // GET: /Album/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Album/Delete/5

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
