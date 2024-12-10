using System.ComponentModel.DataAnnotations;

namespace LifeTracker.Models;

public class Submission
{
    [Required]
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }
    
    [Required]
    public Template? Template { get; set; }

    [Required]
    public User? User { get; set; }
}
