using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u17112631_A2.ViewModels;

namespace u17112631_A2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report()
        {
            Report newReport = new Report();
            newReport.fromDate = new DateTime(2011, 1, 31);
            newReport.toDate = new DateTime(2012, 1, 29);

            return View(newReport);
        }

        [HttpPost]
        public ActionResult Report(Report r)
        {
            // Do the report things

            return View(newReport);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}