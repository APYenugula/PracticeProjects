
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitTestingInMVC.Models;
using UserService;

namespace UnitTestingInMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserMessaging _user;

        public HomeController(IUserMessaging UserMessaging, ILogger<HomeController> logger)
        //public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _user = UserMessaging;
        }

        public IActionResult Index()
        {
            //UserMessaging u = new UserMessaging();

            ViewBag.Output = _user.dbdata();
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