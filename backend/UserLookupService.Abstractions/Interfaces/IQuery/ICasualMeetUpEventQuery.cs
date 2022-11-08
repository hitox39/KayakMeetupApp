using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery
{
    public interface ICasualMeetUpEventQuery 
    {
        Task<CasualMeetUpEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetAllEventsAsync(CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventsByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventsByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventsByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventsByCountry(string Country, CancellationToken cancellationToken);
    }
}
