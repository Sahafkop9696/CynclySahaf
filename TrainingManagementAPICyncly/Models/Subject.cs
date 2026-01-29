using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class Subject
{
    [Key]
    public int SubjectId { get; set; }

    [MaxLength(40)]
    public string? SubjectName { get; set; }

    public string? Remarks { get; set; }

    [MaxLength(10)]
    public string? IsDiscontinued { get; set; }

    public ICollection<FacultySubject> FacultySubjects { get; set; } = new List<FacultySubject>();
}
