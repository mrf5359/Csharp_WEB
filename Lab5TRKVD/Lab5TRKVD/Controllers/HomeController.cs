using Microsoft.AspNetCore.Mvc;
using Lab5TRKVD.Models;
using Lab5TRKVD.ViewModels;

namespace Lab5TRKVD.Controllers
{
    public class HomeController : Controller
    {
        List<Person> people;
        List<Company> companies;
        public HomeController()
        {
            Company microsoft = new Company(1, "Microsoft", "USA");
            Company google = new Company(2, "Google", "USA");
            Company jetbrains = new Company(3, "JetBrains", "Czech Republic");
            companies = new List<Company> { microsoft, google, jetbrains };
            people = new List<Person>
            {
                new Person(1, "Tom", 37, microsoft),
                new Person(2, "Bob", 41, microsoft),
                new Person(3, "Sam", 28, google),
                new Person(4, "Bill", 32, google),
                new Person(5, "Kate", 33, jetbrains),
                new Person(6, "Alex", 25, jetbrains),
            };
        }
        public IActionResult Index(int? companyId)
        {
            // формуємо список компаній для передачі до подання
            List<CompanyModel> compModels = companies
            .Select(c => new CompanyModel(c.Id, c.Name)).ToList();
            // додаємо на перше місце
            compModels.Insert(0, new CompanyModel(0, "Всі"));
            IndexViewModel viewModel = new() { Companies = compModels, People = people };
            // якщо передано id компанії, фільтруємо список
            if (companyId != null && companyId > 0)
                viewModel.People = people.Where(p => p.Work.Id == companyId);
            return View(viewModel);
        }
        public IActionResult People()
        {
            List<PersonModel> peopleModel = people
                .Select(p => new PersonModel(p.Id, p.Name, p.Age, p.Work.Name, p.Work.Country)).ToList();

            return View("People", peopleModel);
        }

    }
}