﻿namespace KayakMeetupService.Abstractions.Models
{
    public class RaceEvent : Event
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; }
    }
}
