using Data.Access.Models;
using System.Collections.Generic;

namespace Data.Access.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAllTasksForEmployee(int employeeId);

        IEnumerable<Task> GetAllTasksForFirstEmployee();

        Task GetTaskDetails(int taskId);

        Task GetTaskDetailsByEmployeeId(int employeeId);

        Task GetDetailsForFirstTask();
    }
}
