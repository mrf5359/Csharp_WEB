using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab9TRKVD.Models;

namespace Lab9TRKVD.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["MarkSortParm"] = sortOrder == "mark_desc" ? "mark_asc" : "mark_desc";

            var applicants = from a in db.Users select a;

            switch (sortOrder)
            {
                case "name_desc":
                    applicants = applicants.OrderByDescending(a => a.Name);
                    break;
                case "mark_desc":
                    applicants = applicants.OrderByDescending(a => a.Mark);
                    break;
                case "mark_asc":
                    applicants = applicants.OrderBy(a => a.Mark);
                    break;
                default:
                    applicants = applicants.OrderBy(a => a.Name);
                    break;
            }

            return View(await applicants.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                User user = new User { Id = id.Value };
                db.Entry(user).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                User? user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null) return View(user);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            db.Users.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
