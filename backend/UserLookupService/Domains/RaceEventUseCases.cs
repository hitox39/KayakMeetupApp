using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Domains
{
    public class RaceEventUseCases
    {

        private readonly IRaceEventRepository _raceEventRepository;
        private readonly IRaceEventQuery _raceEventQuery;
        private readonly ILogger _logger;


        public RaceEventUseCases(
            IRaceEventRepository raceEventRepository,
            IRaceEventQuery raceEventQuery,
            ILogger logger
            )
        {
            _raceEventRepository = raceEventRepository;
            _logger = logger;
            _raceEventQuery = raceEventQuery;
        }

        public async Task<RaceEvent> AddAsync(RaceEvent raceEvent, CancellationToken cancellationToken)
        {
            raceEvent.Id = Guid.NewGuid();
            await _raceEventRepository.AddAsync(raceEvent, cancellationToken);

            return raceEvent;
        }

        public async Task DeleteRaceEventAsync(Guid eventId, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Attempting to delete user: [{eventId}]", eventId);
            await _raceEventRepository.DeleteRaceEventAsync(eventId, cancellationToken);
        }

        public async Task<RaceEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _raceEventQuery.GetEventAsync(id, cancellationToken);
        }

        public async Task UpdateRaceEventAsync(RaceEvent raceEvent, CancellationToken cancellationToken)
        {
            await _raceEventRepository.UpdateRaceEventAsync(raceEvent, cancellationToken);

        }
    }
}
