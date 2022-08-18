using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDataApp.Models;

public record Employee
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EmployeeId { get; set; }
    [StringLength(20)]
    public string FirstName { get; set; }
    [StringLength(20)]
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime StartDate { get; set; }
    public int JobId { get; set; }

    public Job Job { get; set; }
    public ICollection<Shift> Shifts { get; set; }
}
