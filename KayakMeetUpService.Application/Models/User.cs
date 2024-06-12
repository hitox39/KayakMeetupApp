using KayakMeetupService.Data.Models;

namespace KayakMeetupService.Application.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? GivenName { get; set; } = "";
        public string? FamilyName { get; set; } = "";
        public string? Email { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; } = "";
        public State State { get; set; } = State.None;
        public string? CityName { get; set; } = "";
        public string? ZipCode { get; set; } = "";
        public Boat? Boat { get; set; }
    }
}
