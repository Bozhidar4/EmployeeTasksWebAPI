using System.ComponentModel.DataAnnotations;

namespace Data.Access.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityLevelId { get; set; }
        public int StateId { get; set; }
        public string Estimate { get; set; }
        public int EmployeeId { get; set; }
    }
}
