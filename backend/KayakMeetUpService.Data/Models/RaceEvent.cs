﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KayakMeetUpService.Abstractions.Models;

namespace KayakMeetUpService.Data.Models
{
    public class RaceEvent
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public State State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int PrizePool { get; set; }
    }
}

