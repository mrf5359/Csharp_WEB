using Microsoft.AspNetCore.Mvc;

namespace Lab8TRKVD.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
