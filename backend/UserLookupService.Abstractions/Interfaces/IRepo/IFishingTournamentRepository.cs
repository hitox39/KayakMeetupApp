using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IRepo
{
    public interface IFishingTournamentRepository : IEventRepository
    {
        Task<FishingTournamentEvent> AddEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken);
        Task DeleteEventAsync(Guid id, CancellationToken cancellationToken);
        Task<FishingTournamentEvent> UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken);
    }
}
