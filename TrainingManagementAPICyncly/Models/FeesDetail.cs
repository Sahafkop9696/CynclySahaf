using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class FeesDetail
{
    [Key]
    public int FeesId { get; set; }

    public int? BatchId { get; set; }

    [ForeignKey("BatchId")]
    public Batch? Batch { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public string? Remarks { get; set; }
}
