using Data.Access.Models;
using Data.Access.Repositories;
using Services.Enums;
using Services.Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public IEnumerable<TaskModel> GetAllTasksForEmployee(int employeeId)
        {
            var tasks = _taskRepository.GetAllTasksForEmployee(employeeId);
            var result = MapModel(tasks);
            return result;
        }

        public IEnumerable<TaskModel> GetAllTasksForFirstEmployee()
        {
            var tasks = _taskRepository.GetAllTasksForFirstEmployee();
            var result = MapModel(tasks);
            return result;
        }
        
        public TaskModel GetTaskDetails(int taskId)
        {
            var task = _taskRepository.GetTaskDetails(taskId);
            var result = MapModel(task);
            return result;
        }

        public TaskModel GetTaskDetailsByEmployeeId(int employeeId)
        {
            var task = _taskRepository.GetTaskDetailsByEmployeeId(employeeId);
            var result = MapModel(task);
            return result;
        }

        public TaskModel GetFirstTaskDetails()
        {
            var task = _taskRepository.GetDetailsForFirstTask();
            var result = MapModel(task);
            return result;
        }

        private TaskModel MapModel(Task task)
        {
            TaskModel taskModel = new TaskModel
            {
                Title = task.Title,
                Description = task.Description,
                PriorityLevel = Enum.GetName(typeof(PriorityLevelEnum), task.PriorityLevelId),
                State = Enum.GetName(typeof(StateEnum), task.StateId),
                Estimate = task.Estimate
            };

            return taskModel;
        }

        private IEnumerable<TaskModel> MapModel(IEnumerable<Task> tasks)
        {
            var tasksResult = new List<TaskModel>();
            foreach (var task in tasks)
            {
                TaskModel taskModel = new TaskModel
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    PriorityLevel = Enum.GetName(typeof(PriorityLevelEnum), task.PriorityLevelId),
                    State = Enum.GetName(typeof(StateEnum), task.StateId),
                    Estimate = task.Estimate
                };

                tasksResult.Add(taskModel);
            }
            
            return tasksResult;
        }
    }
}
