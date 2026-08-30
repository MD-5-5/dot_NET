using Microsoft.AspNetCore.Mvc;

namespace PractiveWebPages.Controllers
{
    public class ActionResultController : Controller
    {
        public IActionResult Index()
        {
            return View("Hello"); //Hello.cshtml page ko render karega. 
        }

        public IActionResult MyAdd()
        {
            return PartialView("_MyPartial");
        }

        public IActionResult GetData()
        {
            return Json(new { Id = 1001, Name = "Baba MD5" });
        }

        public IActionResult GetContent()
        {
            return Content("Baba is taking gyan of ASP.NET ");
        }

        public IActionResult GoToGitHub()
        {
            return Redirect("https://github.com/MD-5-5");
        }

        public IActionResult DownloadResume()
        {
            return File("~files/Dev_Srivastava.pdf", "application/pdf");
        }

        public IActionResult Error()
        {
            return StatusCode(500);
        }
    }
}
