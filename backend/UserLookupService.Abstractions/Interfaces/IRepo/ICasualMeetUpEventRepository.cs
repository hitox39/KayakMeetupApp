using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IRepo
{
    public interface ICasualMeetUpEventRepository
    {
        Task AddEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken);
        Task DeleteCasualMeetUpEventAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken);
    }
}
