using Microsoft.AspNetCore.Mvc;
using ModelViewController1.Models;
using System.Diagnostics;

namespace ModelViewController1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Product product = new Product();
            /*ViewBag.new1 = "welcome";
            ViewBag.new2 = "Content from controller";
            return View();*/
            student S = new student();

            UGstudent us = new UGstudent()
            {

                stu_id = 123,
                stu_name = "harish",
                marks = 23,
                regdno = 123457
            };
            PGStudent ps = new PGStudent();
            S = us;
            S = ps;
            string result = Display(us);
            return View();
        }
        private string Display(student S)
        {
            string result = "welcome";
            if (S is UGstudent)
            {
                result = result + "mr" + S.stu_name;
            }
            if (S is PGStudent)
            {
                result = result +" "+ " mr " + S.stu_name;
            }
            return result;

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