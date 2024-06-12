namespace KayakMeetupService.Application.Models
{
    public class CasualMeetUpEvent : Event
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Address { get; set; } = string.Empty;
        public string CityName { get; set; }
        public State State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}
