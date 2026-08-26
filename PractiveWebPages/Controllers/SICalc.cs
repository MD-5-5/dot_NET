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
    }
}
