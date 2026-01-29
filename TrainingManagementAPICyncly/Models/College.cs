using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class College
{
    [Key]
    public int CollegeId { get; set; }

    [MaxLength(100)]
    public string? CollegeName { get; set; }

    [MaxLength(100)]
    public string? Location { get; set; }

    public string? Remarks { get; set; }

    public ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
}
