using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockDataUnitTesting1;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDataUnitTesting1.Tests
{
    [TestClass()]
    public class StudentOperationTests
    {
        //Mock<IDataService> mockservice = new Mock<IDataService>();
        //Mock<StudentOperation> mockstudent = new Mock<StudentOperation>(mockservice.Object);
        [TestMethod()]
        public void GetStudentsTest()
        {
            Mock<IDataService> mockservice = new Mock<IDataService>();
            Mock<StudentOperation> mockstudent = new Mock<StudentOperation>(mockservice.Object);
            mockservice.Setup(S => S.GetStudentsData()).Returns(GetTestData);
            List<Student> students = mockstudent.Object.GetStudents();
            var expected = GetExpectedStudents();
            Assert.AreEqual(expected.Count, students.Count);

            //Assert.Fail();
        }
        private List<Student> GetExpectedStudents()
        {
            List<Student> students=new List<Student>();
            students.Add(new Student() { rollno = 1, name = "ab" });
            students.Add(new Student() { rollno = 2, name = "bb" });
            students.Add(new Student() { rollno = 3, name = "cc" });
            return students;
        }
        private List<Student> GetTestData()
        {
            List<Student> students1 = new List<Student>();
            students1.Add(new Student() { rollno = 1, name = "abc" });
            students1.Add(new Student() { rollno = 2, name = "bbc" });
            students1.Add(new Student() { rollno = 3, name = "ccc" });
            return students1;
        }


    }
}