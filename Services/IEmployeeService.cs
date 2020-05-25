using Data.Access.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
