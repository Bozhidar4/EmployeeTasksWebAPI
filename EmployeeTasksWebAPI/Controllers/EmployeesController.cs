using System.Collections.Generic;
using Data.Access.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace EmployeeTasksWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            var result = _employeeService.GetAllEmployees();

            return result;
        }
    }
}