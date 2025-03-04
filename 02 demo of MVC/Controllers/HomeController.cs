using Microsoft.AspNetCore.Mvc;

namespace _02_demo_of_MVC.Controllers
{
    public class HomeController : Controller
    {
        // view :: html page
        // razor page :: html + c#
        public IActionResult Index()
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
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
