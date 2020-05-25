using System.Collections.Generic;

namespace Services.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<TaskModel> Tasks { get; set; }
    }
}
