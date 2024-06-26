using System.ComponentModel.DataAnnotations;

namespace KayakMeetupService.Application.Models
{
    public class Event
    {
        [Required]
        public Guid Id { get; set; } = Guid.Empty;

        [Required]
        public string EventName { get; set; } = string.Empty;

        [Required]
        public string EventDescription { get; set; } = string.Empty;

        [Required]
        public EventType EventType { get; set; } = EventType.None;

        [Required]
        public DateTime EventTime { get; set; } = DateTime.MinValue;

        [Required]
        public string EventOrganizer { get; set; } = string.Empty;

        [Required]
        public string EventOrganizerEmail { get; set; } = string.Empty;

        [Required]
        public string EventOrganizerPhoneNumber { get; set; } = string.Empty;

        [Required]
        public string CityName { get; set; } = string.Empty;

        [Required]
        public State State { get; set; } = State.None;

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
