using MVCTableWhenDataisEmpty.Models;
using System.Web.Mvc;

namespace MVCTableWhenDataisEmpty.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            return View(new DateClass());
        }

    }
}