 using Microsoft.AspNetCore.Mvc;
using RAA_PROJECT.Models;

namespace RAA_PROJECT.Controllers
{
    public class FlightSearchController : Controller
    {
        // GET: FlightSearch
        public ActionResult Index()
        {
            // Initialize model with default values
            var model = new FlightSearchModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult SearchFlights(FlightSearchModel model)
        {
            if (ModelState.IsValid)
            {
                // Process search logic here (e.g., call a service or database)
                TempData["Message"] = $"Searching flights from {model.From} to {model.To}.";
                return RedirectToAction("SearchResults");
            }

            // If validation fails, return to the same view with errors
            return View("Index", model);
        }

        public ActionResult SearchResults()
        {
            // Display results (this is a placeholder)
            ViewBag.Message = TempData["Message"];
            return View();
        }
    }
}
