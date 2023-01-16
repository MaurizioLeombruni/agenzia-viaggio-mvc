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
        public IActionResult Info()
        {
            using (TravelContext db = new TravelContext())
            {
                List<Travel> tours = db.Travels.ToList<Travel>();
                return View("Info", tours);
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


        [HttpGet]
        public IActionResult Update(int id)
        {
            using (TravelContext db = new TravelContext())
            {
                Travel update = db.Travels.Where(tours => tours.Id == id).FirstOrDefault();

                if (update == null)
                {
                    return NotFound("Il post non è stato trovato");
                }

                return View("Update", update);
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Travel form)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", form);
            }

            using (TravelContext db = new TravelContext())
            {
                Travel update = db.Travels.Where(tours => tours.Id == form.Id).FirstOrDefault();

                if (update != null)
                {
                    update.Name = form.Name;
                    update.Description = form.Description;
                    update.ImageUrl = form.ImageUrl;
                    update.Price = form.Price;
                    update.Days = form.Days;
                    update.Destinations = form.Destinations;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound("Il post che volevi modificare non è stato trovato!");
                }
            }

        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            using (TravelContext db = new TravelContext())
            {
                Travel delete = db.Travels.Where(tours => tours.Id == id).FirstOrDefault();

                if (delete != null)
                {
                    db.Travels.Remove(delete);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound("Il post da eliminare non è stato trovato!");
                }
            }
        }
    }


}

