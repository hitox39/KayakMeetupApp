using UserLookupService.Abstractions;

namespace UserLookupService.Data.Models
{
    public class FishingTournamentModelMapper
    {
        public static Abstractions.FishingTournamentEvent ToBusiness(FishingTournamentEvent raceEvent)

        {
            return new Abstractions.FishingTournamentEvent

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

        public static Abstractions.FishingTournamentEvent ToBusiness(AddFishingTournamentEvent raceEvent)
        {
            return new Abstractions.FishingTournamentEvent

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

        public static FishingTournamentEvent ToDatabase(Abstractions.FishingTournamentEvent raceEvent)
        {
            return new FishingTournamentEvent

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


        public static IList<Abstractions.FishingTournamentEvent> ToBusiness(List<FishingTournamentEvent> raceEvents)
        {
            var abstractionFishingTournamentEvents = new List<Abstractions.FishingTournamentEvent>();

            foreach (var raceEvent in raceEvents)
            {
                abstractionFishingTournamentEvents.Add(ToBusiness(raceEvent));
            }

            return abstractionRaceEvents;
        }
    }
}
