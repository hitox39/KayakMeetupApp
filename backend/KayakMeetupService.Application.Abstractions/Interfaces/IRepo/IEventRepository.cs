using KayakMeetupService.Data.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IRepo
{
    public interface IEventRepository
    {
        Task<Event> AddEventAsync(Event Event, CancellationToken cancellationToken = default);
        Task DeleteEventAsync(Guid id, CancellationToken cancellationToken = default);
        Task<Event> UpdateEventAsync(Event Event, CancellationToken cancellationToken = default);
    }
}

