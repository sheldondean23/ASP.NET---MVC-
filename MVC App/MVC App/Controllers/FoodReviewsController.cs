using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_App.Models;
using MVC_App.Models.Entities;

namespace MVC_App.Controllers
{
    public class FoodReviewsController : Controller
    {
        private MVC_AppDB db = new MVC_AppDB();

        // GET: FoodReviews
        public ActionResult Index(string SearchFood = null)
        {
            if (SearchFood == null)
            {
                var model = db.FoodReviews.ToList();
                return View(model);
            }
            else
            {
                var model =
                               from resteraunts in db.FoodReviews
                               orderby resteraunts.DishName
                               where resteraunts.DishName.StartsWith(SearchFood)
                               select resteraunts;
                return View(model);
            }
        }
       
        // GET: FoodReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodReview foodReview = db.FoodReviews.Find(id);
            if (foodReview == null)
            {
                return HttpNotFound();
            }
            return View(foodReview);
        }

        // GET: FoodReviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DishName,Rating")] FoodReview foodReview)
        {
            if (ModelState.IsValid)
            {
                db.FoodReviews.Add(foodReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foodReview);
        }

        // GET: FoodReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodReview foodReview = db.FoodReviews.Find(id);
            if (foodReview == null)
            {
                return HttpNotFound();
            }
            return View(foodReview);
        }

        // POST: FoodReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DishName,Rating")] FoodReview foodReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodReview);
        }

        // GET: FoodReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodReview foodReview = db.FoodReviews.Find(id);
            if (foodReview == null)
            {
                return HttpNotFound();
            }
            return View(foodReview);
        }

        // POST: FoodReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodReview foodReview = db.FoodReviews.Find(id);
            db.FoodReviews.Remove(foodReview);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
