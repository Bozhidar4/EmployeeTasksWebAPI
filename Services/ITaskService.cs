using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public interface ITaskService
    {
        IEnumerable<TaskModel> GetAllTasksForEmployee(int employeeId);

        IEnumerable<TaskModel> GetAllTasksForFirstEmployee();

        TaskModel GetTaskDetails(int taskId);

        TaskModel GetTaskDetailsByEmployeeId(int employeeId);

        TaskModel GetFirstTaskDetails();
    }
}
