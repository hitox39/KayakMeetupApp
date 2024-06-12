using KayakMeetupService.Data.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IQuery
{
    public interface IEventQuery
    {
        Task<IList<Event>> GetAllEventsAsync(CancellationToken cancellationToken = default);
        Task<Event> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<Event>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken);
    }
}
