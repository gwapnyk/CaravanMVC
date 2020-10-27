using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaravanMVC.Controllers
{
    public class LocalController : Controller
    {
        // GET: Local
        public ActionResult California()
        {
            return View();
        }

        public ActionResult Dublin()
        {
            return View();
        }

        public ActionResult Paris()
        {
            return View();
        }
    }
}