using Microsoft.AspNetCore.Mvc;

namespace PractiveWebPages.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection obj)
        {
            double result = 0;

            double num1 = double.Parse(obj["num1"].ToString());
            double num2 = double.Parse(obj["num2"].ToString());

            switch (obj["operation"].ToString())
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Cannot divide by zero.";
                    }
                    break;

                default:
                    ViewBag.ErrorMessage = "Invalid operation.";
                    break;
            }

            ViewBag.Result = result;

            return View();
        }
    }
}