using System.ComponentModel.DataAnnotations;

namespace Data.Access.Models
{
    public class PriorityLevel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
