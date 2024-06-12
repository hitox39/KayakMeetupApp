namespace KayakMeetupService.Abstractions.Interfaces.IRepo
{
    public interface IRaceEventRepository 
    {
        Task AddAsync(RaceEvent raceEvent, CancellationToken cancellationToken);
        Task DeleteRaceEventAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateRaceEventAsync(RaceEvent raceEvent, CancellationToken cancellationToken);
    }
}
