using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Data.Models;
using KayakMeetupService.Data.Query;

namespace KayakMeetupService.Data.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly MainContext _dbContext;
        private readonly CasualMeetUpQueries _casualMeetUpQueries;

        public EventRepository(MainContext dbContext, CasualMeetUpQueries casualMeetUpQueries)
        {
            _dbContext = dbContext;
            _casualMeetUpQueries = casualMeetUpQueries;
        }

        public async Task<Event> AddEventAsync(Event Event, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteEventAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Event> UpdateEventAsync(Event Event, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
