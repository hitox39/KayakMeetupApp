using KayakMeetUpService.Abstractions.Models;

namespace KayakMeetUpService.Data;

public class AddUser
{
    public string? GivenName { get; set; } = "";
    public string? FamilyName { get; set; } = "";
    public string? Email { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; } = "";
    public State State { get; set; } = State.None;
    public string? ZipCode { get; set; } = "";
    public Boat Boat { get; set; }
}
