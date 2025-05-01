using iScent.Data;
using Microsoft.AspNetCore.Mvc;

namespace iScent.Controllers
{
    public class ParfumsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParfumsController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index(string search)
        {
            var parfums = _context.Parfums.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                parfums = parfums.Where(p =>
                    p.Name.ToLower().Contains(search) ||
                    p.Marke.ToLower().Contains(search) ||
                    (p.Kopfnote != null && p.Kopfnote.ToLower().Contains(search)) ||
                    (p.Herznote != null && p.Herznote.ToLower().Contains(search)) ||
                    (p.Basisnote != null && p.Basisnote.ToLower().Contains(search)));
            }

            return View(parfums.ToList());
        }

        public IActionResult Details(int id)
        {
            var parfum = _context.Parfums.FirstOrDefault(p => p.Id == id);
            if (parfum == null) return NotFound();

            return View(parfum);
        }
    }
}
