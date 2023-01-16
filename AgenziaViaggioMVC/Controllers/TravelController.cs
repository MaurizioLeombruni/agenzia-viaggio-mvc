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

        public IActionResult Add()
        {
            return View();
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
