using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class Evaluation
{
    [Key]
    public int EvaluationId { get; set; }

    public int? BatchId { get; set; }

    [ForeignKey("BatchId")]
    public Batch? Batch { get; set; }

    [MaxLength(50)]
    public string? EvaluationName { get; set; }

    public DateOnly? Date { get; set; }

    [MaxLength(50)]
    public string? Topic { get; set; }

    public string? Question { get; set; }

    public string? Description { get; set; }

    public ICollection<TraineeEvaluation> TraineeEvaluations { get; set; } = new List<TraineeEvaluation>();
}
