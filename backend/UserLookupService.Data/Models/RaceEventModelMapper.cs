using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLookupService.Abstractions;

namespace UserLookupService.Data.Models
{
    public class RaceEventModelMapper
    {
        public static Abstractions.RaceEvent ToBusiness(RaceEvent raceEvent)

        {
            return new Abstractions.RaceEvent

            {
                CityName = raceEvent.CityName,
                State = raceEvent.State,
                Country = raceEvent.Country,
                Id = raceEvent.Id,
                Latitude = raceEvent.Latitude,
                Longitude = raceEvent.Longitude,
                PrizePool = raceEvent.PrizePool,
                ZipCode = raceEvent.ZipCode,

            };
        }

        public static Abstractions.RaceEvent ToBusiness(AddRaceEvent raceEvent)
        {
            return new Abstractions.RaceEvent

            {
                CityName = raceEvent.CityName,
                State = raceEvent.State,
                Country = raceEvent.Country,
                Id = raceEvent.Id,
                Latitude = raceEvent.Latitude,
                Longitude = raceEvent.Longitude,
                PrizePool = raceEvent.PrizePool,
                ZipCode = raceEvent.ZipCode,
            };
        }

        public static RaceEvent ToDatabase(Abstractions.RaceEvent raceEvent)
        {
            return new RaceEvent

            {
                CityName = raceEvent.CityName,
                State = raceEvent.State,
                Country = raceEvent.Country,
                Id = raceEvent.Id,
                Latitude = raceEvent.Latitude,
                Longitude = raceEvent.Longitude,
                PrizePool = raceEvent.PrizePool,
                ZipCode = raceEvent.ZipCode,
            };
        }


        public static IList<Abstractions.RaceEvent> ToBusiness(List<RaceEvent> raceEvents)
        {
            var abstractionRaceEvents = new List<Abstractions.RaceEvent>();

            foreach (var raceEvent in raceEvents)
            {
                abstractionRaceEvents.Add(ToBusiness(raceEvent));
            }

            return abstractionRaceEvents;
        }
    }
}
