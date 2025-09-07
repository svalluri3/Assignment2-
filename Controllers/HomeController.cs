using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Celsius = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TemperatureModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Celsius = model.CalculateCelsius();
            }
            else
            {
                ViewBag.Celsius = null;
            }

            return View(model);
        }
    }
}
