using Microsoft.EntityFrameworkCore;

namespace Data.Access.Models
{
    public interface IEmployeeContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Task> Tasks { get; set; }
    }
}
