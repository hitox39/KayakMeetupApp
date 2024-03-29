﻿using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Threading;
using KayakMeetUpService.Abstractions.Interfaces;
using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Abstractions.Models;

namespace KayakMeetUpService.Abstractions;

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
        await _fishingTournamentRepository.UpdateEventAsync(fishingTournamentEvent, cancellationToken);

    }
}
