using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using textfiletoCSV.Models;
using System.IO;
using System.Text;

namespace textfiletoCSV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //SqlConnection _con = new SqlConnection("Data Source=AYENUGUL-L-5517\\SQLEXPRESS;Initial Catalog=studentdb;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234");
        //_con.Open();
        string details = "";
        //string nameOfFile = @"C:\Temp\Anusha.txt?";
        //FileInfo fi=new FileInfo(nameOfFile);


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            string? nameOfFile = @"C:\Temp\Anusha.txt";
            FileInfo fi = new FileInfo(nameOfFile);
            List<student12> students = new List<student12>();
            using (StreamReader reader = fi.OpenText())
            {
                

                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    student12 stu = new student12();
                    var rawData = s.Split(",");
                    stu.rollno = int.Parse(rawData[0]);
                    stu.name= rawData[1];
                    stu.mark1 = int.Parse(rawData[2]);
                    stu.mark2 = int.Parse(rawData[3]);
                    stu.total = stu.mark1 + stu.mark2;
                    students.Add(stu);

                }
            }


            return View("studentList",students);
        }

        public IActionResult studentcreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult studentcreate(student12 student) 
        {
            string? nameOfFile = @"C:\Temp\Anusha12.txt";
            FileInfo fi = new FileInfo(nameOfFile);
            //fi.AppendText(student.rollno);
           
            details += student.rollno+",";
            details += student.name+",";
            details += student.mark1 + ",";
            details += student.mark2+",";
            details += student.mark1+student.mark2;
            using (StreamWriter sw = fi.AppendText())
            {
               // sw.WriteLine("student_details"); 
                sw.WriteLine(details);
            }
              return View("studentcreate",student);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View("View");
            
        }
        [HttpPost]
        public IActionResult Edit(student12 student)
        {
            //string? nameOfFile = @"C:\Temp\Anusha.txt";
            //FileInfo fi = new FileInfo(nameOfFile);
            //List<student12> students = new List<student12>();
            //while()
            String path = @"C:\Temp\Anusha.txt";
            List<String> lines = new List<String>();



            using (StreamReader reader = new StreamReader(path))
            {
                String line;



                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        String[] split = line.Split(',');



                        if (int.Parse(split[0]) == student.rollno)
                        {
                            split[1] = student.name;
                            split[2] = student.mark1.ToString();
                            split[3] = student.mark2.ToString();
                            split[4] = (student.mark1 + student.mark2).ToString();
                            line = String.Join(",", split);
                        }
                    }



                    lines.Add(line);
                }
            }



            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }



            return RedirectToAction("Index");
            //return View("View", student);



        }
        private static student12 getStudent(int id)
        {
            string fileName = "C:\\Temp\\Anusha.txt";
            FileInfo fileInfo = new FileInfo(fileName);
            student12 student = new student12();
            using (StreamReader r = fileInfo.OpenText())
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    string[] values = line.Split(",");
                    if (int.Parse(values[0]) == id)
                    {
                        student.rollno = int.Parse(values[0]);
                        student.name = values[1];
                        student.mark1 = int.Parse(values[2]);
                        student.mark2 = int.Parse(values[3]);
                        student.total = int.Parse(values[4]);
                        break;
                    }
                }
            }



            return student;
        }
        public IActionResult Delete(int id)
        {
            student12 student = getStudent(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(IFormCollection form)
        {
            String path = @"C:\Temp\Anusha.txt";
            List<String> lines = new List<String>();



            using (StreamReader reader = new StreamReader(path))
            {
                String line;



                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        String[] split = line.Split(',');



                        if (int.Parse(split[0]) != int.Parse(form["id"]))
                        {
                            line = String.Join(",", split);
                            lines.Add(line);
                        }
                    }



                }
            }



            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }



            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}