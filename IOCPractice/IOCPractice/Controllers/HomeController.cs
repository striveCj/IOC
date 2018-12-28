using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOCPractice.Core;

namespace IOCPractice.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPeople _service;

        public HomeController(IPeople service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          
            ViewBag.Message = _service.Run();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}