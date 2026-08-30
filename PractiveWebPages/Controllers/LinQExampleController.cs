using Microsoft.AspNetCore.Mvc;

namespace PractiveWebPages.Controllers
{
    public class LinQExampleController : Controller
    {
        public IActionResult Index()
        {
            String[] names = { "John", "Jane", "Alice", "Bob", "Charlie" };
            var s = names.Where(n => n.Length > 3);
            ViewBag.Names = s;
            return View();
        }
    }
}
