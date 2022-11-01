using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IRepo
{
    public interface ICasualMeetUpEventRepository
    {
        Task<CasualMeetUpEvent> AddAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken);
        Task DeleteCasualMeetUpEventAsync(Guid id, CancellationToken cancellationToken);
        Task<CasualMeetUpEvent> UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken);
    }
}
