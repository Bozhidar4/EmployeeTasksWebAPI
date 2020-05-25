namespace Services.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PriorityLevel { get; set; }
        public string State { get; set; }
        public string Estimate { get; set; }
        public int EmployeeId { get; set; }
    }
}
