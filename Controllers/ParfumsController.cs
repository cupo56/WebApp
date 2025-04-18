using Microsoft.AspNetCore.Mvc;
using iScent.Models;
using System.Collections.Generic;
using System.Linq;

namespace iScent.Controllers
{
    public class ParfumsController : Controller
    {
        private static List<Parfum> _parfums = new()
        {
            new Parfum
            {
                Id = 1,
                Name = "Dior Sauvage",
                Marke = "Dior",
                Beschreibung = "Frischer, würziger Herrenduft mit einem modernen Twist.",
                Duftnoten = "Bergamotte, Ambroxan, Pfeffer",
                BildUrl = "/images/sauvage.svg"
            },
            new Parfum
            {
                Id = 2,
                Name = "Miss Dior Eau de Parfum",
                Marke = "Dior",
                Beschreibung = "Romantischer, blumiger Damenduft mit Noten von Rose und Pfingstrose.",
                Duftnoten = "Rose, Pfingstrose, Iris, Vanille",
                BildUrl = "/images/missdior.svg"
            }
        };

        public IActionResult Index()
        {
            return View(_parfums);
        }

        public IActionResult Details(int id)
        {
            var parfum = _parfums.FirstOrDefault(p => p.Id == id);
            if (parfum == null) return NotFound();

            return View(parfum);
        }
    }
}
