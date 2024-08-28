using Microsoft.AspNetCore.Mvc;

    namespace Lab7TRKVD.Controllers
    {
        public class HomeController : Controller
        {
            [HttpGet]
            public IActionResult Index() => View();

            [HttpPost]
            public IActionResult SubmitForm(string username, string password, int age, string group, string specialization, string comment)
            {
                // Сохраняем данные в сессии
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Password", password);
                HttpContext.Session.SetInt32("Age", age);
                HttpContext.Session.SetString("Group", group);
                HttpContext.Session.SetString("Specialization", specialization);
                HttpContext.Session.SetString("Comment", comment);

                // Перенаправление на страницу профиля
                return RedirectToAction("Profile");
            }

            public IActionResult Profile()
            {
                // Извлекаем данные из сессии
                ViewBag.Username = HttpContext.Session.GetString("Username");
                ViewBag.Password = HttpContext.Session.GetString("Password");
                ViewBag.Age = HttpContext.Session.GetInt32("Age");
                ViewBag.Group = HttpContext.Session.GetString("Group");
                ViewBag.Specialization = HttpContext.Session.GetString("Specialization");
                ViewBag.Comment = HttpContext.Session.GetString("Comment");

                return View();
            }

            public IActionResult About() => View();

        }
    }
