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
                ZipCode = casualMeetUpEvent.ZipCode,
                EventName= casualMeetUpEvent.EventName,
                Address = casualMeetUpEvent.Address
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
                Address = casualMeetUpEvent.Address,
                EventName= casualMeetUpEvent.EventName,
                ZipCode= casualMeetUpEvent.Zip  
                

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
                ZipCode = casualMeetUpEvent.ZipCode,
                Address = casualMeetUpEvent.Address,
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
