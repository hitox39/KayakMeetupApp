using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Abstractions;

public class AddUser
{
    public string GivenName { get; set; } = string.Empty;
    public string FamilyName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; } = string.Empty;
    public State State { get; set; } = State.None;
    public string ZipCode { get; set; } = string.Empty;
    public Boat? Boat { get; set; }
}
