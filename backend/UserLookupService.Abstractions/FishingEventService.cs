using KayakMeetupService.Abstractions.Interfaces;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Abstractions;

public class FishingEventService : IEvent<FishingTournamentEvent>
{
    private readonly IFishingTournamentRepository _fishingTournamentRepository;
    private readonly ILogger<FishingEventService> _logger;
    private readonly IFishingTournamentQueries _fishingTournamentQuery;

    public FishingEventService(IFishingTournamentRepository fishingTournamentRepository, ILogger<FishingEventService> logger, IFishingTournamentQueries fishingTournamentQuery)
    {
        _fishingTournamentRepository = fishingTournamentRepository;
        _logger = logger;
        _fishingTournamentQuery = fishingTournamentQuery;
    }

    public async Task AddEventAsync(FishingTournamentEvent FishingTournamentEvent, CancellationToken cancellationToken)
    {
        FishingTournamentEvent.Id = Guid.NewGuid();

        await _fishingTournamentRepository.AddEventAsync(FishingTournamentEvent, cancellationToken);

    }

    public async Task<FishingTournamentEvent> GetEventAsync(Guid eventid, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Attempting to get user: [{eventId}]", eventid);
        return await _fishingTournamentQuery.GetEventAsync(eventid, cancellationToken);
    }

    public async Task DeleteEventAsync(Guid eventId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Attempting to delete event: [{eventId}]", eventId);
        await _fishingTournamentRepository.DeleteEventAsync(eventId, cancellationToken);
    }

    public async Task UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
    {
        var updatedEvent = await _fishingTournamentRepository.UpdateEventAsync(fishingTournamentEvent, cancellationToken);

    }
}
