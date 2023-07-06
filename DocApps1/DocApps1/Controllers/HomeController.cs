using DocApps1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace DocApps1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //string myDb1ConnectionString = Configuration.GetConnectionString("myDb1");
            SqlConnection sqlconnection = new SqlConnection("Data Source=AYENUGUL-L-5517\\SQLEXPRESS;Initial Catalog=salesdb;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234");
            SqlCommand c = new SqlCommand("Sp_insert_brand", sqlconnection);
            sqlconnection.Open();
            c.CommandType = System.Data.CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@id", 104893);
            c.Parameters.AddWithValue("@name", "djhgsfsfjdh");
            //c.ExecuteNonQuery();
            //c.Parameters.AddWithValue("@id", 6443);
            //c.Parameters.AddWithValue("@name", "djhgsfsfjdh");
            c.ExecuteNonQuery();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}