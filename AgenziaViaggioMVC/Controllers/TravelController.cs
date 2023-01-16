using AgenziaViaggioMVC.Database;
using AgenziaViaggioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenziaViaggioMVC.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Index()
        {
            using (TravelContext db = new TravelContext())
            {
                List<Travel> tours = db.Travels.ToList<Travel>();
                return View("Index", tours);
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Travel form)
        {
            if (!ModelState.IsValid)
            {
                return View("Add", form);
            }

            using (TravelContext db = new TravelContext())
            {
                db.Travels.Add(form);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }


    }
}
