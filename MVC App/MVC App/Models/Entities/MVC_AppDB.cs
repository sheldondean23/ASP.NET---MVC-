using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_App.Models.Entities
{
    public class MVC_AppDB : DbContext
    {
        public DbSet<FoodReview> FoodReviews { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
    }
}