using UserLookupService.Abstractions;

namespace UserLookupService.Data.Models
{
    public class RaceEventModelMapper
    {
        public static Abstractions.Models.RaceEvent ToBusiness(RaceEvent raceEvent)

        {
            return new Abstractions.Models.RaceEvent

            {
                CityName = raceEvent.CityName,
                State = raceEvent.State,
                Country = raceEvent.Country,
                Address = raceEvent.Address,
                Id = raceEvent.Id,
                Latitude = raceEvent.Latitude,
                Longitude = raceEvent.Longitude,
                PrizePool = raceEvent.PrizePool,
                ZipCode = raceEvent.ZipCode,

            };
        }

        public static Abstractions.Models.RaceEvent ToBusiness(AddRaceEvent raceEvent)
        {
            return new Abstractions.Models.RaceEvent
            {
                CityName = raceEvent.CityName,
                State = raceEvent.State,
                Country = raceEvent.Country,
                Id = Guid.NewGuid(),
                Address = raceEvent.Address,
                Latitude = raceEvent.Latitude,
                Longitude = raceEvent.Longitude,
                PrizePool = raceEvent.PrizePool,
                ZipCode = raceEvent.ZipCode,
            };
        }

        public static RaceEvent ToDatabase(Abstractions.Models.RaceEvent raceEvent)
        {
            return new RaceEvent
            {
                CityName = raceEvent.CityName,
                State = raceEvent.State,
                Country = raceEvent.Country,
                Id = raceEvent.Id,
                Address = raceEvent.Address,
                Latitude = raceEvent.Latitude,
                Longitude = raceEvent.Longitude,
                PrizePool = raceEvent.PrizePool,
                ZipCode = raceEvent.ZipCode,
            };
        }


        public static IList<Abstractions.Models.RaceEvent> ToBusiness(List<RaceEvent> raceEvents)
        {
            var abstractionRaceEvents = new List<Abstractions.Models.RaceEvent>();

            foreach (var raceEvent in raceEvents)
            {
                abstractionRaceEvents.Add(ToBusiness(raceEvent));
            }

            return abstractionRaceEvents;
        }
    }
}
