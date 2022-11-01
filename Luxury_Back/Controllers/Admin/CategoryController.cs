using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Luxury_Back.Controllers.Admin
{
    public class CategoryController : Controller
    {
        const string ViewPath = "Views/Admin/Category/";
        private LuxuryDb luxuryDb;

        public CategoryController(LuxuryDb luxuryDb)
        {
            this.luxuryDb = luxuryDb;
        }

        public IActionResult Index()
        {
            //return luxuryDb.categories.Include(c => c.translations).Include(c=>c.parent).ThenInclude(p=>p.translations).Where(c => c.Id == 2).First().parent.name;
            var categories = luxuryDb.categories.Include(c => c.translations).Include(c=>c.parent).ThenInclude(p=>p.translations).ToList();
            return View($"{ViewPath}Index.cshtml", categories);
        }
    }
}
