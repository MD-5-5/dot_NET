using Microsoft.AspNetCore.Mvc;

namespace PractiveWebPages.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Location()
        {
            return View();
        }

        public IActionResult Ratings()
        {
            return View();
        }
    }
}
