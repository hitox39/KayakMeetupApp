using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Data.Models
{
    public class CasualMeetUpEvent
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
        public int ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; }
    }
}
