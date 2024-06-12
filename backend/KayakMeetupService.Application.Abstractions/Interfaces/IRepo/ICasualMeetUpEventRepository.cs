using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IRepo
{
    public interface ICasualMeetUpEventRepository
    {
        Task AddAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken);
        Task DeleteCasualMeetUpEventAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken);
    }
}
