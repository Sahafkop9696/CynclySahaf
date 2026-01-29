using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManagement.API.Models;

public class Resource
{
    [Key]
    public int ResourceId { get; set; }

    public int? ResourceTypeId { get; set; }

    [ForeignKey("ResourceTypeId")]
    public ResourceType? ResourceType { get; set; }

    [MaxLength(50)]
    public string? ResourceName { get; set; }

    [MaxLength(200)]
    public string? Url { get; set; }

    [MaxLength(600)]
    public string? Description { get; set; }
}
