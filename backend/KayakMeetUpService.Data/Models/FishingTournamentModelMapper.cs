using KayakMeetUpService.Abstractions;

namespace KayakMeetUpService.Data.Models
{
    public class FishingTournamentModelMapper
    {

        public static Abstractions.Models.FishingTournamentEvent ToBusiness(AddFishingTournamentEvent fishingTournamentEvent)
        {
            return new Abstractions.Models.FishingTournamentEvent

            {
                EventName = fishingTournamentEvent.EventName,
                Address = fishingTournamentEvent.Address,
                CityName = fishingTournamentEvent.CityName,
                State = fishingTournamentEvent.State,
                Country = fishingTournamentEvent.Country,
                Id = fishingTournamentEvent.Id,
                PrizePool = fishingTournamentEvent.PrizePool,
                ZipCode = fishingTournamentEvent.ZipCode,
            };
        }
        public static Abstractions.Models.FishingTournamentEvent ToBusiness(FishingTournamentEvent fishingTournamentEvent)
        {
            return new Abstractions.Models.FishingTournamentEvent

            {   
                EventName = fishingTournamentEvent.EventName,
                Address = fishingTournamentEvent.Address,
                CityName = fishingTournamentEvent.CityName,
                State = fishingTournamentEvent.State,
                Country = fishingTournamentEvent.Country,
                Id = fishingTournamentEvent.Id,
                PrizePool = fishingTournamentEvent.PrizePool,
                ZipCode = fishingTournamentEvent.ZipCode,
            };
        }

        public static FishingTournamentEvent ToDatabase(Abstractions.Models.FishingTournamentEvent fishingTournamentEvent)
        {
            return new FishingTournamentEvent

            {
                EventName = fishingTournamentEvent.EventName,
                Address = fishingTournamentEvent.Address,
                CityName = fishingTournamentEvent.CityName,
                State = fishingTournamentEvent.State,
                Country = fishingTournamentEvent.Country,
                Id = fishingTournamentEvent.Id,
                PrizePool = fishingTournamentEvent.PrizePool,
                ZipCode = fishingTournamentEvent.ZipCode,
            };
        }


        public static IList<Abstractions.Models.FishingTournamentEvent> ToBusiness(List<FishingTournamentEvent> fishingTournamentEvents)
        {
            var abstractionFishingTournamentEvents = new List<Abstractions.Models.FishingTournamentEvent>();

            foreach (var fishingTournamentEvent in fishingTournamentEvents)
            {
                abstractionFishingTournamentEvents.Add(ToBusiness(fishingTournamentEvent));
            }

            return abstractionFishingTournamentEvents;
        }
    }
}
