using Data.Access.Models;
using System.Collections.Generic;

namespace Data.Access.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
