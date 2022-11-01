namespace UserLookupService.Abstractions.Interfaces
{
    public interface IEvent<T>
    {
        public Task AddEventAsync(T Event);
        public Task DeleteEventAsync(T Event);  
        public Task UpdateEventAsync(T Event);
        public Task GetEventAsync(T Event);

    }
}
