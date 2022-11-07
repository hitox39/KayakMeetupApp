using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IRepo
{
    public interface IFishingTournamentRepository 
    {
        Task AddEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken);
        Task DeleteEventAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken);
    }
}
