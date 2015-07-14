using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class FoodReview
    {
        public int ID { get; set; }
        public string DishName { get; set; }
        public int Rating { get; set; }
    }
}