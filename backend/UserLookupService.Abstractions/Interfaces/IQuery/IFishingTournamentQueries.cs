using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery
{
    public interface IFishingTournamentQueries : IEventQuery
    {
        Task<FishingTournamentEvent> GetEventAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetAllEventsAsync(Guid id, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken);
        Task<IList<FishingTournamentEvent>> GetEventByCuntry(string Country, CancellationToken cancellationToken);


    }
}
