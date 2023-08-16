using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.Application.CarWorkshop;

public class CarWorkshopDto
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(20, MinimumLength = 2, ErrorMessage = "Length of this field must be between 2 - 20 characters")]
    public string Name { get; set; } = default!;
    [Required(ErrorMessage = "Description is required")]
    public string? Description { get; set; }
    public string? About { get; set; }
    [StringLength(12, MinimumLength = 8, ErrorMessage = "Length of this field must be between 8 - 12 characters")]
    public string? PhoneNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? EncodedName { get; set; }
}