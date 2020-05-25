using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models;

namespace EmployeeTasksWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET api/tasks/5
        [HttpGet("{employeeId}")]
        public IEnumerable<TaskModel> GetAllTasksForEmployee(int employeeId)
        {
            var result = _taskService.GetAllTasksForEmployee(employeeId);

            return result;
        }

        // GET api/tasks/firstemployeetasks
        [HttpGet("firstemployeetasks")]
        public IEnumerable<TaskModel> GetAllTasksForFirstEmployee()
        {
            var result = _taskService.GetAllTasksForFirstEmployee();

            return result;
        }

        // GET api/tasks/details/5
        [HttpGet("details/{taskId}")]
        public TaskModel GetTaskDetails(int taskId)
        {
            var result = _taskService.GetTaskDetails(taskId);

            return result;
        }

        // GET api/tasks/details/5
        [HttpGet("{employeeId}/detail")]
        public TaskModel GetTaskDetailsByEmployeeId(int employeeId)
        {
            var result = _taskService.GetTaskDetailsByEmployeeId(employeeId);

            return result;
        }

        [HttpGet("details/firsttask")]
        public TaskModel GetDetailsForFirstTask()
        {
            var result = _taskService.GetFirstTaskDetails();

            return result;
        }
    }
}