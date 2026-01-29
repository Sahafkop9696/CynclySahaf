using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class BatchDetail
{
    [Key]
    public int BatchDetailId { get; set; }

    public int? BatchId { get; set; }

    [ForeignKey("BatchId")]
    public Batch? Batch { get; set; }

    public DateOnly? Date { get; set; }

    public double? HoursTaken { get; set; }

    public string? TopicsTaken { get; set; }

    public string? Remarks { get; set; }
}
