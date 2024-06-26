using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using CasualMeetUpEvent = KayakMeetUpService.Abstractions.Models.CasualMeetUpEvent;

namespace KayakMeetUpService.Domains
{
    public class CasualMeetUpUseCases
    {
        private readonly ICasualMeetUpEventRepository _casualMeetUpEventRepository;
        private readonly ICasualMeetUpEventQuery _casualMeetUpEventQuery;
        private readonly ILogger<CasualMeetUpUseCases> _logger;


        public CasualMeetUpUseCases(
            ICasualMeetUpEventRepository casualMeetUpEventRepository,
            ICasualMeetUpEventQuery casualMeetUpEventQuery, 
            ILogger<CasualMeetUpUseCases> logger
            )
        {
            _casualMeetUpEventRepository = casualMeetUpEventRepository;
            _logger = logger;
            _casualMeetUpEventQuery = casualMeetUpEventQuery;
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
            return await _casualMeetUpEventQuery.GetEventAsync(id, cancellationToken);
        }

        public async Task UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            await _casualMeetUpEventRepository.UpdateCasualMeetUpEventAsync(casualMeetUpEvent, cancellationToken);
        }
    }
}
