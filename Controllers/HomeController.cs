using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TemperatureConversionModel());
        }

        [HttpPost]
        public IActionResult Index(TemperatureConversionModel model, string submitButton)
        {
            if (submitButton == "Clear")
            {
                model.Clear();
                ModelState.Clear(); // clear validation messages
                return View(model);
            }

            if (ModelState.IsValid)
            {
                model.Calculate(); // perform conversion
            }

            return View(model);
        }
    }
}
