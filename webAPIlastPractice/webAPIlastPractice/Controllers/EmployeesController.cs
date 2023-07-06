using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPIlastPractice.Models;
using EmployeeDataAccess2;
using System.Data.Entity;
using System.Web.Http;

namespace webAPIlastPractice.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(EmployeeDBEntities e=new EmployeeDBEntities())
            {
                return e.employees.ToList();
            }

        }
    }
}
