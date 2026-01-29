using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class Trainee
{
    [Key]
    public int TraineeId { get; set; }

    public int? BatchId { get; set; }

    [ForeignKey("BatchId")]
    public Batch? Batch { get; set; }

    public int? CollegeId { get; set; }

    [ForeignKey("CollegeId")]
    public College? College { get; set; }

    [MaxLength(40)]
    public string? TraineeName { get; set; }

    [MaxLength(40)]
    public string? TraineeLocation { get; set; }

    [MaxLength(40)]
    public string? Email { get; set; }

    [MaxLength(15)]
    public string? Phone { get; set; }

    [MaxLength(1)]
    public string? Discontinue { get; set; }

    public ICollection<TraineeAssignment> TraineeAssignments { get; set; } = new List<TraineeAssignment>();
    public ICollection<TraineeEvaluation> TraineeEvaluations { get; set; } = new List<TraineeEvaluation>();
}
