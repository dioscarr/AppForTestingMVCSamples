using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class Home1Controller : Controller
    {
        //4q3
        // GET: /Home1/

        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "Dominican Republic",
                "Colombia",
                "United State"
            };
            return View();
        }

    }
}
