//using KayakMeetupService.Abstractions.Interfaces.IQuery;
//using KayakMeetupService.Abstractions.Interfaces.IRepo;
//using KayakMeetupService.Abstractions.Models;
//using KayakMeetupService.Application.Abstractions.Interfaces.IRepo;
//using KayakMeetupService.Application.Models.Event;
//using Microsoft.Extensions.Logging;

//namespace KayakMeetupService.Application.UseCases.EventUseCases;

//public class FishingEventUseCase : IEvent<FishingTournamentEvent>
//{
//    private readonly IFishingTournamentRepository _fishingTournamentRepository;
//    private readonly ILogger<FishingEventUseCase> _logger;
//    private readonly IFishingTournamentQueries _fishingTournamentQuery;

//    public FishingEventUseCase(
//        IFishingTournamentRepository fishingTournamentRepository,
//        ILogger<FishingEventUseCase> logger, 
//        IFishingTournamentQueries fishingTournamentQuery
//        )
//    {
//        _fishingTournamentRepository = fishingTournamentRepository;
//        _logger = logger;
//        _fishingTournamentQuery = fishingTournamentQuery;
//    }

//    public async Task AddEventAsync(FishingTournamentEvent FishingTournamentEvent, CancellationToken cancellationToken)
//    {
//        FishingTournamentEvent.Id = Guid.NewGuid();
       

//        await _fishingTournamentRepository.AddEventAsync(FishingTournamentEvent, cancellationToken);

//    }

//    public async Task<FishingTournamentEvent> GetEventAsync(Guid eventId, CancellationToken cancellationToken)
//    {
//        _logger.LogInformation($"Attempting to get user: [{eventId}]", eventId);
//        return await _fishingTournamentQuery.GetEventAsync(eventId, cancellationToken);
//    }

//    public async Task DeleteEventAsync(Guid eventId, CancellationToken cancellationToken)
//    {
//        _logger.LogInformation($"Attempting to delete event: [{eventId}]", eventId);
//        await _fishingTournamentRepository.DeleteEventAsync(eventId, cancellationToken);
//    }

//    public async Task UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
//    {
//        var updatedEvent = await _fishingTournamentRepository.UpdateEventAsync(fishingTournamentEvent, cancellationToken);
//    }
//}
