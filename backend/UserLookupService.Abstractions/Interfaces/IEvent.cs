namespace UserLookupService.Abstractions.Interfaces
{
    public interface IEvent<T>
    {
        public Task AddEventAsync(T Event, CancellationToken cancellationToken);
        public Task DeleteEventAsync(Guid id, CancellationToken cancellationToken);  
        public Task UpdateEventAsync(T Event, CancellationToken cancellationToken);
        public Task<T> GetEventAsync(Guid id, CancellationToken cancellationToken);

    }
}
