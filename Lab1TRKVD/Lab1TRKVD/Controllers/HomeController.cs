using Microsoft.AspNetCore.Mvc;
namespace Lab1TRKVD.Controllers
{
    public class HomeController:Controller  
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
