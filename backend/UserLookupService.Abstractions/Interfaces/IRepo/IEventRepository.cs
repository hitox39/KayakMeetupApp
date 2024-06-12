using Microsoft.AspNetCore.Mvc.ViewEngines;
using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Abstractions.Interfaces.IRepo
{
    public interface IEventRepository
    {
        Task<Event> AddAsync(Event Event, CancellationToken cancellationToken);
        Task DeleteEventAsync(Guid id, CancellationToken cancellationToken);
        Task<Event> UpdateEventAsync(Event Event, CancellationToken cancellationToken);
    }
}

