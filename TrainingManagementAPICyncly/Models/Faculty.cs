using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class Faculty
{
    [Key]
    public int FacultyId { get; set; }

    [MaxLength(40)]
    public string? FacultyName { get; set; }

    public string? Remarks { get; set; }

    [MaxLength(1)]
    public string? Discontinue { get; set; }

    public ICollection<FacultySubject> FacultySubjects { get; set; } = new List<FacultySubject>();
}
