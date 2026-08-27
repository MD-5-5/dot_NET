using Microsoft.AspNetCore.Mvc;
using PractiveWebPages.Models;
namespace PractiveWebPages.Controllers
{
    public class SICalc : Controller
    {
        public IActionResult Index()
        {
            SI obj = new SI();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(SI obj)
        {
            double simpleInterest = (obj.Principal * obj.Rate * obj.Time) / 100;
            ViewBag.SimpleInterest = "Result is: " + simpleInterest;
            return View(obj);
        }
    }
}
