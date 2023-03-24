using KayakMeetUpService.Abstractions.Models;

namespace KayakMeetUpService.Abstractions.Interfaces.IQuery
{
    public interface IRaceEventQuery 
    {
        Task<RaceEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetAllEventsAsync(CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByName(string eventName, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByZipCodeAsync(string ZipCode, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByCountry(string Country, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByAddress(string Address, CancellationToken cancellationToken);
        Task<IList<RaceEvent>> GetEventByPrizePool(int Prizepool, CancellationToken cancellationToken);



    }
}
