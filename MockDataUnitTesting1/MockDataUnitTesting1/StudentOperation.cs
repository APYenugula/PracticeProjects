using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataUnitTesting1
{
    public class StudentOperation : IStudentOperation
    {
        private readonly IDataService dataservice1 = new DataService();
        public StudentOperation()
        {

        }
        public StudentOperation(IDataService dataservice)
        {
            this.dataservice1 = dataservice;
        }

        public List<Student> GetStudents()
        {
            //IDataService dataService = new DataService();
            var result = dataservice1.GetStudentsData();
            return result;
        }
    }
}
