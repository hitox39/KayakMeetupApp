using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Threading;
using UserLookupService.Abstractions.Interfaces;
using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions;

public class FishingEventService : IEvent
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

    public async Task<FishingTournamentEvent> AddEventAsync(FishingTournamentEvent FishingTournamentEvent, CancellationToken cancellationToken)
    {
        FishingTournamentEvent.Id = Guid.NewGuid();

        await _fishingTournamentRepository.AddAsync(FishingTournamentEvent, cancellationToken);

        return FishingTournamentEvent;
    }

    public async Task<FishingTournamentEvent> GetEventAsync(Guid eventid, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Attempting to get user: [{eventId}]", eventid);
        return await _fishingTournamentQuery.GetEventAsync(eventid, cancellationToken);
    }

    public async Task<FishingTournamentEvent> DeleteEventAsync(Guid eventId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Attempting to delete event: [{eventId}]", eventId);
        await _fishingTournamentRepository.DeleteEventAsync(eventId, cancellationToken);
    }

    public async Task<FishingTournamentEvent> UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
    {
        var updatedEvent = await _fishingTournamentRepository.UpdateEventAsync(fishingTournamentEvent, cancellationToken);

        return updatedEvent;
    }
}
