using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Data.Models;
using CasualMeetUpEvent = UserLookupService.Abstractions.Models.CasualMeetUpEvent;

namespace UserLookupService.Domains
{
    public class CasualMeetUpUseCases
    {
        private readonly ICasualMeetUpEventRepository _casualMeetUpEventRepository;
        private readonly ICasualMeetUpEventRepository _casualMeetUpEventQueries;
        private readonly ILogger _logger;


        public CasualMeetUpUseCases(ICasualMeetUpEventRepository casualMeetUpEventRepository, ICasualMeetUpEventRepository casualMeetUpEventQueries, ILogger logger)
        {
            _casualMeetUpEventRepository = casualMeetUpEventRepository;
            _logger = logger;
            _casualMeetUpEventQueries = casualMeetUpEventQueries;
        }

        public async Task<CasualMeetUpEvent> AddEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            casualMeetUpEvent.Id = Guid.NewGuid();
            await _casualMeetUpEventRepository.AddEventAsync(casualMeetUpEvent, cancellationToken);

            return casualMeetUpEvent;
        }

        public async Task DeleteCasualMeetUpEventAsync(Guid eventId, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Attempting to delete user: [{eventId}]", eventId);
            await _casualMeetUpEventRepository.DeleteCasualMeetUpEventAsync(eventId, cancellationToken);
        }

        public async Task<CasualMeetUpEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _casualMeetUpEventQueries.GetEventAsync(id, cancellationToken);
        }

        public async Task<CasualMeetUpEvent> UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            var updatedEvent = await _casualMeetUpEventRepository.UpdateCasualMeetUpEventAsync(UserModelMapper.ToDatabase(casualMeetUpEvent), cancellationToken);

            return updatedEvent;
        }
    }
}
