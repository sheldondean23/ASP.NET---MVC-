using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class TableOfContextController : Controller
    {
        // GET: Foods
        [Httpget]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string name)
        {
            var fooditem = name;
            return Content(fooditem);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Search()
        {
            return Content("Hello World");
        }
    }
}