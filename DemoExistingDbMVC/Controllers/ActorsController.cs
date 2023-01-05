using DemoExistingDbMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoExistingDbMVC.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ActorDbContext _context;
        public ActorsController(ActorDbContext context)
        {
            _context = context;
        }   

        public IActionResult Index()
        {
            return View(_context.Actors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actors actors)
        {
            if (!ModelState.IsValid)
            {
                _context.Actors.Add(actors);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(actors);
        }
    }
}
