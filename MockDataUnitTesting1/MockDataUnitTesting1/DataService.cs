using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataUnitTesting1
{
    internal class DataService : IDataService
    {
        public DataService()
        {
        }
        public List<Student> GetStudentsData()
        {
            List<Student> data = new List<Student>();
            data.Add(new Student() { rollno = 1, name = "ab" });
            data.Add(new Student() { rollno = 2, name = "bb" });
            data.Add(new Student() { rollno = 3, name = "cc" });
            return data;


        }
    }
}
