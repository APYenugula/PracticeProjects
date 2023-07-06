using Microsoft.AspNetCore.Mvc;

namespace ModelViewController1.Views
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
