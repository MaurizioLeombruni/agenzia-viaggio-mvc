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

