namespace KayakMeetUpService.Data.Models
{
    public static class CasualMeetUpModelMapper
    {
        public static Abstractions.Models.CasualMeetUpEvent ToBusiness(CasualMeetUpEvent casualMeetUpEvent)
        {
            return new Abstractions.Models.CasualMeetUpEvent
            {
                CityName = casualMeetUpEvent.CityName,
                State = casualMeetUpEvent.State,
                Country = casualMeetUpEvent.Country,
                Id = casualMeetUpEvent.Id,
                Latitude = casualMeetUpEvent.Latitude,
                Longitude = casualMeetUpEvent.Longitude,
                ZipCode = casualMeetUpEvent.ZipCode,

            };
        }

        public static Abstractions.Models.CasualMeetUpEvent ToBusiness(Abstractions.AddCasualMeetUpEvent casualMeetUpEvent)
        {
            return new Abstractions.Models.CasualMeetUpEvent
            {
                CityName = casualMeetUpEvent.CityName,
                State = casualMeetUpEvent.State,
                Country = casualMeetUpEvent.Country,
                Id = casualMeetUpEvent.Id,
                Latitude = casualMeetUpEvent.Latitude,
                Longitude = casualMeetUpEvent.Longitude,
                ZipCode = casualMeetUpEvent.ZipCode,

            };
        }

        public static CasualMeetUpEvent ToDatabase(Abstractions.Models.CasualMeetUpEvent casualMeetUpEvent)
        {
            return new CasualMeetUpEvent
            {
                CityName = casualMeetUpEvent.CityName,
                State = casualMeetUpEvent.State,
                Country = casualMeetUpEvent.Country,
                Id = casualMeetUpEvent.Id,
                Latitude = casualMeetUpEvent.Latitude,
                Longitude = casualMeetUpEvent.Longitude,
                ZipCode = casualMeetUpEvent.ZipCode,
            };
        }



        public static IList<Abstractions.Models.CasualMeetUpEvent> ToBusiness(List<CasualMeetUpEvent> casualMeetUpEvents)
        {
            var abstractionCasualMeetUpEvents = new List<Abstractions.Models.CasualMeetUpEvent>();

            foreach (var casualMeetUpEvent in casualMeetUpEvents)
            {
                abstractionCasualMeetUpEvents.Add(ToBusiness(casualMeetUpEvent));
            }

            return abstractionCasualMeetUpEvents;
        }

        
    }
}
