using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mk866815MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS 4200 description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Morgan Klimack Contact Info.";

            return View();
        }
    }
}