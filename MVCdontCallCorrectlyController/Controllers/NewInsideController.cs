using System.Web.Mvc;

namespace MVCdontCallCorrectlyController.Controllers
{
    public class NewInsideController : Controller
    {
        // GET: NewInside
        public ActionResult Index()
        {
            ViewBag.test = "test";
            return View();
        }
    }
}