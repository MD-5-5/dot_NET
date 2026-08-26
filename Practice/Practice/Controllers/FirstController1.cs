using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class FirstController1 : Controller
    {
        public IActionResult Index()
        {

            return View(); 
        }
    }
}
