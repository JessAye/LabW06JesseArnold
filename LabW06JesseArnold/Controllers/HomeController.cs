using LabW06JesseArnold.Models;
using LabW06JesseArnold.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabW06JesseArnold.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepo;
        public HomeController(DbUserRepository userRepo, ILogger<HomeController> logger)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}