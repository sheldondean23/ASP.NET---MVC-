using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class Ingredients
    {
        public int ID { get; set; }
        public string Main { get; set; }
        public string Seasonings { get; set; }
        public string Other { get; set; }
        public int TimeInMin { get; set; }
        public int DishID { get; set; }
    }
}