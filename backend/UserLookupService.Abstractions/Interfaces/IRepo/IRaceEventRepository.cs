namespace UserLookupService.Abstractions.Interfaces.IRepo
{
    public interface IRaceEventRepository : IEventRepository
    {
        Task<RaceEvent> AddAsync(RaceEvent raceEvent, CancellationToken cancellationToken);
        Task DeleteRaceEventAsync(Guid id, CancellationToken cancellationToken);
        Task<RaceEvent> UpdateRaceEventAsync(RaceEvent raceEvent, CancellationToken cancellationToken);
    }
}
