﻿namespace KayakMeetUpService.Abstractions.Models
{
    public class CasualMeetUpEvent 
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
