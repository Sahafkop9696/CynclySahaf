using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class TraineeEvaluation
{
    [Key]
    public int TraineeEvaluationId { get; set; }

    public int? EvaluationId { get; set; }

    [ForeignKey("EvaluationId")]
    public Evaluation? Evaluation { get; set; }

    public int? TraineeId { get; set; }

    [ForeignKey("TraineeId")]
    public Trainee? Trainee { get; set; }

    public double? Score { get; set; }

    public string? Remarks { get; set; }
}
