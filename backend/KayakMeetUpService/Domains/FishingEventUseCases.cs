using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Abstractions.Models;
using KayakMeetUpService.Data.Repository;


namespace KayakMeetUpService.Domains
{
    public class FishingTournamentEventUseCases
    {
        private readonly IFishingTournamentRepository _fishingTournamentRepository;
        private readonly IFishingTournamentQueries _fishingTournamentQueries;
        private readonly ILogger<FishingTournamentEventUseCases> _logger;


        public FishingTournamentEventUseCases(
            IFishingTournamentRepository fishingTournamentRepository, 
            IFishingTournamentQueries fishingTournamentQueries, 
            ILogger<FishingTournamentEventUseCases> logger
            )
        {
            _fishingTournamentRepository = fishingTournamentRepository;
            _logger = logger;
            _fishingTournamentQueries = fishingTournamentQueries;
        }

        public async Task<FishingTournamentEvent> AddEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {
            fishingTournamentEvent.Id = Guid.NewGuid();
            await _fishingTournamentRepository.AddEventAsync(fishingTournamentEvent, cancellationToken);

            return fishingTournamentEvent;
        }

        public async Task DeleteEventAsync(Guid eventId, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Attempting to delete user: [{eventId}]", eventId);
            await _fishingTournamentRepository.DeleteEventAsync(eventId, cancellationToken);
        }

        public async Task<FishingTournamentEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _fishingTournamentQueries.GetEventAsync(id, cancellationToken);
        }

        public async Task UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {
            await _fishingTournamentRepository.UpdateEventAsync(fishingTournamentEvent, cancellationToken);

        }
    }
}
