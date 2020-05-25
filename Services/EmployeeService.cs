using System.Collections.Generic;
using Data.Access.Models;
using Data.Access.Repositories;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var allEmployees = _employeeRepository.GetAllEmployees();

            return allEmployees;
        }
    }
}
