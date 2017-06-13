using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            ViewBag.country = new List<string>
            {"India","USA"
            };

            ViewData["name"] = new List<String>
            {
                "Nirav","Patel"
            };
            return View();
        }

        public String print()
        {
            return "<h1>Print Function</h1>";
        }
    }
}