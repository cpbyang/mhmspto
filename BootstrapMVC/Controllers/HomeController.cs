using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Board Members";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Upcoming Events";

            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.Message = "Calendar";

            return View();
        }

        public ActionResult Documents()
        {
            ViewBag.Message = "Documents";

            return View();
        }

        public ActionResult Committees()
        {
            ViewBag.Message = "Committees";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SupplyKit()
        {
            ViewBag.Message = "Supplies Kit";

            return View();
        }

        public PartialViewResult SupplyKitPartial()
        {
            return PartialView();
        }
    }
}