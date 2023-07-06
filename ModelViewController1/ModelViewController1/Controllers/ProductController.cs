using Microsoft.AspNetCore.Mvc;
using ModelViewController1.Models;

namespace ModelViewController1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product pro = new Product();
            pro.id = 17;
            pro.name = "Walson";
            pro.price = 240;
            return View(pro);
        }
    }
}
