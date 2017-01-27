using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace animalProject1.Controllers
{
    [RoutePrefix("nature")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [Route("demo")]
        public ViewResult demo()
        {
            ViewBag.Message = "Your demo page.";

            return View("demo");
        }



    }
}