using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class TraineeAssignment
{
    [Key]
    public int AssignmentId { get; set; }

    public int? TraineeId { get; set; }

    [ForeignKey("TraineeId")]
    public Trainee? Trainee { get; set; }

    [Column("Asssignment")]
    [MaxLength(50)]
    public string? Assignment { get; set; }

    public double? Score { get; set; }

    public string? Remarks { get; set; }

    [MaxLength(200)]
    public string? Status { get; set; }
}
