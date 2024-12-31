
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            RegisterLog(employee, ActionType.Created);
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Employee updatedEmployee)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return NotFound();

            employee.Name = updatedEmployee.Name;
            employee.Address = updatedEmployee.Address;
            employee.Extension = updatedEmployee.Extension;
            employee.WorkEmail = updatedEmployee.WorkEmail;
            employee.Department = updatedEmployee.Department;
            employee.Salary = updatedEmployee.Salary;
            employee.HireDate = updatedEmployee.HireDate;

            _context.SaveChanges();
            RegisterLog(employee, ActionType.Updated);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return NotFound();

            _context.Employees.Remove(employee);
            RegisterLog(employee, ActionType.Deleted);
            _context.SaveChanges();
            return NoContent();
        }

        private void RegisterLog(Employee employee, ActionType actionType)
        {
            var log = new EmployeeLog
            {
                ActionType = actionType,
                Name = employee.Name,
                Address = employee.Address,
                Extension = employee.Extension,
                WorkEmail = employee.WorkEmail,
                Department = employee.Department,
                Salary = employee.Salary,
                HireDate = employee.HireDate
            };

            _context.EmployeeLogs.Add(log);
            _context.SaveChanges();
        }
    }
}