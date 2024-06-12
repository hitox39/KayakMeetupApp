namespace KayakMeetupService.Data.Models
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string CityName { get; set; } = string.Empty;
        public State State { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
}
