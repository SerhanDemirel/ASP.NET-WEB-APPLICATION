using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda ()
        {
            return View();
        }
        public ActionResult Takim()
        {
            return View();
        }
        public ActionResult Servis ()
        {
            return View();

        }
        public ActionResult Portfoy()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}