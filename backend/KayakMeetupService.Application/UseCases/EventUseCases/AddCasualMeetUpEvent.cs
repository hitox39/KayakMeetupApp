﻿using KayakMeetupService.Abstractions.Models;
using KayakMeetupService.Application.Models.Event;

namespace KayakMeetupService.Application.UseCases.EventUseCases
{
    public class AddCasualMeetUpEvent : CasualMeetUpEvent
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public State State { get; set; }
        public int Zip { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; }
    }
}
