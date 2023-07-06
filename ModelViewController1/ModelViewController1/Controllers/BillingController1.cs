using Microsoft.AspNetCore.Mvc;
using ModelViewController1.Models;

namespace ModelViewController1.Controllers
{
    public class BillingController1 : Controller
    {
        public IActionResult Index()
        {
            Billing bill = new Billing();
            bill.billId = 17;
            bill.price = 2300;
            bill.item = "washingMachine";
            bill.contactNo = 88987659;
            
            return View(bill);
        }
    }
}
