using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFMvcProject.Models;

namespace EFMvcProject.Controllers
{
    public class AuthorController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using(var context = new EfDbWebContext())
            {
                var model = await context.Authors.AsNoTracking().ToListAsync();
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName")] Author author)
        {
            using (var context = new EfDbWebContext())
            {
                context.Add(author);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }

}