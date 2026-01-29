using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class Batch
{
    [Key]
    public int BatchId { get; set; }

    [MaxLength(40)]
    public string? BatchName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? TentativeEndDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? Fees { get; set; }

    public double? FeesPaid { get; set; }

    public double? Duration { get; set; }

    public double? HoursTaken { get; set; }

    [MaxLength(200)]
    public string? Status { get; set; }

    public string? Details { get; set; }

    public string? Remarks { get; set; }

    public ICollection<BatchDetail> BatchDetails { get; set; } = new List<BatchDetail>();
    public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    public ICollection<FeesDetail> FeesDetails { get; set; } = new List<FeesDetail>();
    public ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
}
