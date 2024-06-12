using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Application.Models.Event
{
    public class Event
    {
        public Guid Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public EventType EventType { get; set; } = EventType.None;
        public DateTime EventTime { get; set; }
        public string EventOrganizer { get; set; } = string.Empty;
        public string EventOrganizerEmail { get; set; } = string.Empty;
        public string EventOrganizerPhoneNumber { get; set; } = string.Empty;
        public string CityName { get; set; } = string.Empty;
        public State State { get; set; } = State.None;
        public int ZipCode { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
