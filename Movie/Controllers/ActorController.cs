using Microsoft.AspNetCore.Mvc;
using Movieee.Data;
using Movieee.Models;

namespace Movieee.Controllers
{
    public class ActorController : Controller
    {
        private readonly ApplicationDbContext db;

        public ActorController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Actor> Actors = db.Actors;

            return View(Actors);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actor);
                db.SaveChanges();
                TempData["success"] = "Category Created";
                return RedirectToAction("Index");
            }
            return View(actor);
        }
    }
}