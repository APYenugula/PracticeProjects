using docApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace docApp2.Controllers
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
            SqlConnection con = new SqlConnection("Data Source=AYENUGUL-L-5517\\SQLEXPRESS;Initial Catalog=salesdb;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234");
            //SqlCommand cmd = new SqlCommand("select * from brands", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from brands", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            List<brands> brands = new List<brands>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                brands brand = new brands()
                {
                id = int.Parse(row["brand_id"].ToString()),
                name = row["brand_name"].ToString()
                };
                brands.Add(brand);
            }

            return View(brands);
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