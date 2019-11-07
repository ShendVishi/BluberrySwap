using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueberrySwap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            ViewBag.Description = "This application is developed by Minzah Anees, Vihard Doshi, Shend Vishi, as a coursework for COMP 425 at LUC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us here";

            return View();
        }
    }
}