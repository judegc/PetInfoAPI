using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeShopRegistrationContext context = new CoffeeShopRegistrationContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View();
        }

        public IActionResult EmployeeHome()
        {
            return View();
        }

        public IActionResult AddOrRedeemPoints()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            List<RegisteredUser> registeredUsers = context.RegisteredUsers.ToList();
            return View(registeredUsers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddMemberToDb(RegisteredUser registeredUser)
        {
            registeredUser.TimeStamp = DateTime.Now;
            context.RegisteredUsers.Add(registeredUser);
            context.SaveChanges();

            return RedirectToAction("Welcome");
        }

        public IActionResult RegistrationList()
        {
            List<RegisteredUser> registeredUsers = context.RegisteredUsers.ToList();
            return View(registeredUsers);
        }


    }
}