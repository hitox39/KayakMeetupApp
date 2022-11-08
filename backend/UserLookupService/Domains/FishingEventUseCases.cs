using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Data.Models;
using UserLookupService.Data.Repository;
using FishingEvent = UserLookupService.Abstractions.Models.FishingTournamentEvent;

namespace UserLookupService.Domains
{
    public class FishingEventUseCases
    {
        private readonly IFishingTournamentRepository _fishingTournamentRepository;
        private readonly IFishingTournamentQueries _fishingTournamentQueries;
        private readonly ILogger _logger;


        public FishingEventUseCases(IFishingTournamentRepository fishingTournamentRepository, IFishingTournamentQueries fishingTournamentQueries, ILogger logger)
        {
            _fishingTournamentRepository = fishingTournamentRepository;
            _logger = logger;
            _fishingTournamentQueries = fishingTournamentQueries;
        }

        public async Task<FishingEvent> AddEventAsync(FishingEvent fishingEvent, CancellationToken cancellationToken)
        {
            fishingEvent.Id = Guid.NewGuid();
            await _fishingTournamentRepository.AddEventAsync(fishingEvent, cancellationToken);

            return fishingEvent;
        }

        public async Task DeleteEventAsync(Guid eventId, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Attempting to delete user: [{eventId}]", eventId);
            await _fishingTournamentRepository.DeleteEventAsync(eventId, cancellationToken);
        }

        public async Task<FishingEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _fishingTournamentQueries.GetEventAsync(id, cancellationToken);
        }

        public async Task<Data.Models.FishingTournamentEvent> UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {
            var updatedEvent = await _fishingTournamentRepository.UpdateEventAsync(UserModelMapper.ToDatabase(fishingTournamentEvent), cancellationToken);

            return updatedEvent;
        }
    }
}
