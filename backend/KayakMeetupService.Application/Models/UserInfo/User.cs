using System.ComponentModel.DataAnnotations;

namespace KayakMeetupService.Application.Models;

public class User
{
    public Guid Id { get; set; }

    [Required] 
    public string DisplayName { get; set; } = string.Empty;

    [Required]
    public string GivenName { get; set; } = string.Empty;

    [Required]
    public string FamilyName { get; set; } = string.Empty;

    [Required]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string Address { get; set; } = string.Empty;

    [Required]
    public State State { get; set; } = State.None;

    [Required]
    public string CityName { get; set; } = string.Empty;

    [Required]
    public string ZipCode { get; set; } = string.Empty;

    public Boat? Boat { get; set; }
}
