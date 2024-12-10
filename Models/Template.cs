using System.ComponentModel.DataAnnotations;

namespace LifeTracker.Models;

public class Template
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    public User? User { get; set; }
}
