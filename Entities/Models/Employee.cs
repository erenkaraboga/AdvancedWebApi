using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public int Id { get; set; }
        [Required(ErrorMessage ="FirstName is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string? Position { get; set; }

        [ForeignKey(nameof(Project))]
        public Guid? ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
