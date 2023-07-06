using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webapisample1.Models;
using static Azure.Core.HttpHeader;

namespace webapisample1.Controllers
{
    [ApiController]
    [Route("employeedetails/[controller]")]
    public class EmployeesController : Controller
    {
        static List<employee> names = new List<employee>();
        private readonly Webapiexample0806Context _context;

        public EmployeesController(Webapiexample0806Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Employees.ToList());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("provide records");
            }
            try
            {
                _context.Add(employee);
                _context.SaveChanges();
                return Ok(_context.Employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(Employee emp)
        {
            if (emp == null)
            {
                return BadRequest("Customer cannot be null");
            }
            if ((_context.Employees?.Any(e => e.Id == emp.Id)).GetValueOrDefault())
            {
                _context.Update(emp);
                _context.SaveChanges();
                return Ok(_context.Employees.ToList());
            }
            else
            {
                return NotFound("Employee does not exist");
            }
        }

    }
}
