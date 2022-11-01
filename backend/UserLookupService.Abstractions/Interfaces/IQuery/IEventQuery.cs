using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery
{
    public interface IEventQuery
    {
        Task<Event> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<Event>> GetAllEventsAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByCuntry(string Country, CancellationToken cancellationToken);

    }
}
