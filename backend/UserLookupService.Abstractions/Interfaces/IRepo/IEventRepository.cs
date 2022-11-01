using Microsoft.AspNetCore.Mvc.ViewEngines;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IRepo
{
    public interface IEventRepository
    {
        Task<Event> AddAsync(Event Event, CancellationToken cancellationToken);
        Task DeleteEventAsync(Guid id, CancellationToken cancellationToken);
        Task<Event> UpdateEventAsync(Event Event, CancellationToken cancellationToken);
    }
}

