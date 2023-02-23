using KayakMeetUpService.Abstractions.Models;

namespace KayakMeetUpService.Abstractions.Interfaces.IQuery
{
    public interface IFishingTournamentQueries 
    {
        Task<FishingTournamentEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetAllEventsAsync(CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByZipCodeAsync(string ZipCode, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByCountry(string Country, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByAddress(string Address, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByName(string Name, CancellationToken cancellationToken);


    }
}
