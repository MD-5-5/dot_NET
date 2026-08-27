using Microsoft.AspNetCore.Mvc;
using PractiveWebPages.Models;
namespace PractiveWebPages.Controllers
{
    public class SICalc : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            SI obj = new SI();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(SI obj)
        {
            double simpleInterest = (obj.Principal * obj.Rate * obj.Time) / 100; //getter
            ViewBag.SimpleInterest = "Result is: " + simpleInterest; //ASP.NET MVC/Core MVC mein ViewBag ka kaam hota hai Controller se View (HTML/Razor page) ko temporary data bhejna.
            return View(obj); //return View(obj) ka matlab hai ki humne jo object (obj) pass kiya hai, usko View mein bhej rahe hain. Isse View mein hum obj ke properties ko access kar sakte hain.
        }


    }
}
