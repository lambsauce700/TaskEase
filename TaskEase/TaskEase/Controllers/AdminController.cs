using Microsoft.AspNetCore.Mvc;
using TaskEase.Data;
using TaskEase.Models;
using TaskEase.Models.Domain;
namespace TaskEase.Controllers
{
   
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AdminController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
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

        [HttpPost]

        public async Task<IActionResult> Users(UsersModel addUserRequest)
        {
            var user = new User()
            { 
            
                Name = addUserRequest.Name,
                Email = addUserRequest.Email,
                Password = addUserRequest.Password



            };

            await applicationDbContext.Users.AddAsync(user);
            await applicationDbContext.SaveChangesAsync();
            return RedirectToAction("Users");
        }
    }
    
}
