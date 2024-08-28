using Microsoft.AspNetCore.Mvc;

namespace Lab3TRKVD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var items = new List<string> { "БУЙ 1", "БУЙ 2", "БУЙ 3" };
            return View(items);
        }
    }
}
