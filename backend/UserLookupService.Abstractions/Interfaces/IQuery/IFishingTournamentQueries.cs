using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IQuery
{
    public interface IFishingTournamentQueries 
    {
        Task<FishingTournamentEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetAllEventsAsync(CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventsByCountry(string Country, CancellationToken cancellationToken);


    }
}
