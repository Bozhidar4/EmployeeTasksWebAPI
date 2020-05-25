using Data.Access.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Access.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeContext _employeeContext;

        public EmployeeRepository(IEmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var allEmployees = _employeeContext.Employees.Include(e => e.Tasks).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            return allEmployees;
        }
    }
}
