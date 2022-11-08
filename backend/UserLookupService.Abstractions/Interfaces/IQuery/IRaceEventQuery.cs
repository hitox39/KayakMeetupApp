using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery
{
    public interface IRaceEventQuery 
    {
        Task<RaceEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetAllEventsAsync(CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByCountry(string Country, CancellationToken cancellationToken);
    }
}
