using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Lab8TRKVD.Models;
using Microsoft.Extensions.Logging;

namespace Lab8TRKVD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View(new MyViewModel());

        public IActionResult About() => View();
        public string Contacts() => "Contacts page";
        public string GetPerson(int id, string name, int age) => $"id={id} name={name} age={age}";

        [HttpPost]
        public IActionResult SubmitForm(MyViewModel model)
        {
            _logger.LogInformation($"Received form data: TextValue={model.TextValue}, NumericValue={model.NumericValue}, Password={model.Password}, IsChecked={model.IsChecked}, SelectedOption={model.SelectedOption}, SelectedValue={model.SelectedValue}");

            return View("Index", model);
        }

    }
}