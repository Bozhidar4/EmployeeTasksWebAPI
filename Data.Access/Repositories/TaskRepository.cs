using Data.Access.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Access.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IEmployeeContext _employeeContext;

        public TaskRepository(IEmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public IEnumerable<Task> GetAllTasksForEmployee(int employeeId)
        {
            var allEmployeeTasks = _employeeContext.Tasks.Where(t => t.EmployeeId == employeeId).OrderBy(x => x.PriorityLevelId);

            return allEmployeeTasks;
        }

        public IEnumerable<Task> GetAllTasksForFirstEmployee()
        {
            var firstEmployeeId = _employeeContext.Employees.OrderBy(e => e.FirstName).ThenBy(x => x.LastName).Select(x => x.Id).FirstOrDefault();
            var firstEmployeeTaskList = _employeeContext.Tasks.Where(t => t.EmployeeId == firstEmployeeId).OrderBy(x => x.PriorityLevelId);

            return firstEmployeeTaskList;
        }
        
        public Task GetTaskDetails(int taskId)
        {
            var task = _employeeContext.Tasks.Find(taskId);

            return task;
        }

        public Task GetTaskDetailsByEmployeeId(int employeeId)
        {
            var task = _employeeContext.Tasks.Where(t => t.EmployeeId == employeeId).FirstOrDefault();

            return task;
        }

        public Task GetDetailsForFirstTask()
        {
            var firstEmployeeId = _employeeContext.Employees.OrderBy(e => e.FirstName).ThenBy(x => x.LastName).Select(x => x.Id).FirstOrDefault();
            var firstTaskDetails = _employeeContext.Tasks.Where(t => t.EmployeeId == firstEmployeeId).FirstOrDefault();

            return firstTaskDetails;
        }
    }
}
