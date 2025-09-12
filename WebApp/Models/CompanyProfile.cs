using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class CompanyProfile
{
    [Required]
    [StringLength(100)]
    public string CompanyName { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string Address { get; set; } = string.Empty;

    [Required]
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Url]
    public string Website { get; set; } = string.Empty;

    [Required]
    [StringLength(1000)]
    public string AboutUs { get; set; } = string.Empty;
}

