using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionResultWithRedirect.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      

        public ActionResult Upload()
        {
       
            return new RedirectResult("http://www.google.com");
       
        }
    }
}