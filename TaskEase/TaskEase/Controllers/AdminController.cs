using Microsoft.AspNetCore.Mvc;

namespace TaskEase.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Requests()
        {
            return View();
        }
    }
}
