using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class ResourceType
{
    [Key]
    public int ResourceTypeId { get; set; }

    [Column("ResourceType")]
    [MaxLength(30)]
    public string? ResourceTypeName { get; set; } // Renamed to avoid member name same as enclosing type, mapped to column

    [MaxLength(100)]
    public string? Description { get; set; }

    [MaxLength(10)]
    public string? IsPaid { get; set; }

    [MaxLength(10)]
    public string? IsDiscontinued { get; set; }
}
