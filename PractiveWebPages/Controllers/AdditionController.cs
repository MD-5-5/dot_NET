using Microsoft.AspNetCore.Mvc;
using PractiveWebPages.Models;
using PractiveWebPages.Services;
namespace PractiveWebPages.Controllers
{
    public class AdditionController : Controller
    {
        private AdditionService _service;
        public AdditionController(AdditionService _service)
        {
            this._service = _service;
        }
        public IActionResult Index()
        {
            AdditionModel model = new AdditionModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(AdditionModel ho)
        {

            int result =  _service.Addtion(ho.Num1, ho.Num2);
 
            ViewBag.Result = $"The addition of {ho.Num1} and {ho.Num2} is: {result}";
            return View();
        }
    }
}
