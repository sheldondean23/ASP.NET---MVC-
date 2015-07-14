using MVC_App.Models;
using MVC_App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class ReviewController : Controller
    {
        MVC_AppDB _db = new MVC_AppDB();

        // GET: Review
        public ActionResult Index()
        {
            return View(_db.FoodReviews.ToList());
        }

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        public ActionResult Create(FoodReview review)
        {
            if (ModelState.IsValid)
            try
            {
                _db.FoodReviews.Add(review);
                _db.SaveChanges();
                

                
            }
            catch (Exception ex)
            {
                
            }
            return RedirectToAction("Index");
        }

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _db.FoodReviews.Single(FoodReview => FoodReview.ID == id);

            return View(review);
        }

        // POST: Review/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _db.FoodReviews.Single(FoodReview => FoodReview.ID == id);

        if (TryUpdateModel(review))
        {
            //...
            return RedirectToAction("Index");
        }
        return View(review);
        }

        // GET: Review/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Review/Delete/5
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
        protected override void Dispose(bool disposing)
        {
          if (_db != null)
          {
              _db.Dispose();
          }
          base.Dispose(disposing);
        }
    }
}
