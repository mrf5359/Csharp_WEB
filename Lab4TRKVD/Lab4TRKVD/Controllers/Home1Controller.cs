using Microsoft.AspNetCore.Mvc;

namespace Lab4TRKVD.Controllers
{
    public class Home1Controller : Controller
    {
        public IActionResult RoutingInfo()
        {
            return View();
        }

        public IActionResult ControllersInfo(int? id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
