using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery
{
    public interface ICasualMeetUpEventQuery : IEventQuery
    {
        Task<CasualMeetUpEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetAllEventsAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<CasualMeetUpEvent>> GetEventByCuntry(string Country, CancellationToken cancellationToken);
    }
}
