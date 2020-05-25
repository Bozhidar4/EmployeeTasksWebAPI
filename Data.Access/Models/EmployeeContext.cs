using Microsoft.EntityFrameworkCore;

namespace Data.Access.Models
{
    public class EmployeeContext : DbContext, IEmployeeContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>().HasData(
                new State() { Id = 1, Name = "New" },
                new State() { Id = 2, Name = "Active" },
                new State() { Id = 3, Name = "Resolved" },
                new State() { Id = 4, Name = "Closed" });

            modelBuilder.Entity<PriorityLevel>().HasData(
                new PriorityLevel() { Id = 1, Name = "Critical" },
                new PriorityLevel() { Id = 2, Name = "Medium" },
                new PriorityLevel() { Id = 3, Name = "Low" });
            
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, FirstName = "Ross", LastName = "Geller" },
                new Employee() { Id = 2, FirstName = "Rachel", LastName = "Green" },
                new Employee() { Id = 3, FirstName = "Chandler", LastName = "Bing" },
                new Employee() { Id = 4, FirstName = "Joey", LastName = "Tribbiani" },
                new Employee() { Id = 5, FirstName = "Monica", LastName = "Geller-Bing" },
                new Employee() { Id = 6, FirstName = "Phoebe", LastName = "Buffay-Hannigan" });
            
            modelBuilder.Entity<Task>().HasData(
                new Task() { Id = 1, Title = "Task 1", Description = "Description 1", PriorityLevelId = 1, StateId = 2, Estimate = "1", EmployeeId = 1 },
                new Task() { Id = 2, Title = "Task 2", Description = "Description 2", PriorityLevelId = 1, StateId = 2, Estimate = "1", EmployeeId = 2 },
                new Task() { Id = 3, Title = "Task 3", Description = "Description 3", PriorityLevelId = 3, StateId = 1, Estimate = "2", EmployeeId = 1 },
                new Task() { Id = 4, Title = "Task 4", Description = "Description 4", PriorityLevelId = 3, StateId = 3, Estimate = "2", EmployeeId = 2 },
                new Task() { Id = 5, Title = "Task 5", Description = "Description 5", PriorityLevelId = 2, StateId = 3, Estimate = "3", EmployeeId = 1 },
                new Task() { Id = 6, Title = "Task 6", Description = "Description 6", PriorityLevelId = 2, StateId = 4, Estimate = "3", EmployeeId = 2 },
                new Task() { Id = 7, Title = "Task 7", Description = "Description 7", PriorityLevelId = 1, StateId = 2, Estimate = "1", EmployeeId = 3 },
                new Task() { Id = 8, Title = "Task 8", Description = "Description 8", PriorityLevelId = 1, StateId = 2, Estimate = "1", EmployeeId = 4 },
                new Task() { Id = 9, Title = "Task 9", Description = "Description 9", PriorityLevelId = 3, StateId = 1, Estimate = "2", EmployeeId = 3 },
                new Task() { Id = 10, Title = "Task 10", Description = "Description 10", PriorityLevelId = 3, StateId = 3, Estimate = "2", EmployeeId = 4 },
                new Task() { Id = 11, Title = "Task 11", Description = "Description 11", PriorityLevelId = 2, StateId = 3, Estimate = "3", EmployeeId = 3 },
                new Task() { Id = 12, Title = "Task 12", Description = "Description 12", PriorityLevelId = 2, StateId = 4, Estimate = "3", EmployeeId = 4 },
                new Task() { Id = 13, Title = "Task 13", Description = "Description 13", PriorityLevelId = 1, StateId = 4, Estimate = "1", EmployeeId = 5 },
                new Task() { Id = 14, Title = "Task 14", Description = "Description 14", PriorityLevelId = 1, StateId = 4, Estimate = "1", EmployeeId = 6 },
                new Task() { Id = 15, Title = "Task 15", Description = "Description 15", PriorityLevelId = 3, StateId = 3, Estimate = "2", EmployeeId = 5 },
                new Task() { Id = 16, Title = "Task 16", Description = "Description 16", PriorityLevelId = 3, StateId = 3, Estimate = "2", EmployeeId = 6 },
                new Task() { Id = 17, Title = "Task 17", Description = "Description 17", PriorityLevelId = 2, StateId = 1, Estimate = "3", EmployeeId = 5 },
                new Task() { Id = 18, Title = "Task 18", Description = "Description 18", PriorityLevelId = 2, StateId = 1, Estimate = "3", EmployeeId = 6 });
        }
    }
}
