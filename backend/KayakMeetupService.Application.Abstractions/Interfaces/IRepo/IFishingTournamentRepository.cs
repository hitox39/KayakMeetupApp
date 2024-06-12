using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IRepo
{
    public interface IFishingTournamentRepository 
    {
        Task AddEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken);
        Task DeleteEventAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken);
    }
}
