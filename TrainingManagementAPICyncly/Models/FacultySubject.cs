using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

[Table("FacultiesSubjects")]
public class FacultySubject
{
    [Key]
    public int FacultySubjectId { get; set; }

    public int? FacultyId { get; set; }

    [ForeignKey("FacultyId")]
    public Faculty? Faculty { get; set; }

    public int? SubjectId { get; set; }

    [ForeignKey("SubjectId")]
    public Subject? Subject { get; set; }

    public string? Remarks { get; set; }

    [MaxLength(1)]
    public string? Discontinue { get; set; }
}
