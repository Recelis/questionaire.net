using System.ComponentModel.DataAnnotations;

namespace LifeTracker.Models;

public class User
{
    [Required]
    public int Id { get; set; }

    public String? Name { get; set; }

    [Required]
    public String? Email { get; set; }
}
