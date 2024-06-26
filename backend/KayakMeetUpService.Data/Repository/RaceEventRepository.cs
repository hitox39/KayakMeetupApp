using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Data.Models;
using KayakMeetUpService.Data.Query;


namespace KayakMeetUpService.Data.Repository
{
    public class RaceEventRepository : IRaceEventRepository
    {
        private readonly MainContext _dbContext;
        private readonly IRaceEventQuery _raceEventQueries;

        public RaceEventRepository(MainContext dbContext, IRaceEventQuery raceEventQueries)
        {
            _dbContext = dbContext;
            _raceEventQueries = raceEventQueries;
        }
        public async Task AddAsync(Abstractions.Models.RaceEvent raceEvent, CancellationToken cancellationToken)
        {
            await _dbContext.RaceEvents.AddAsync(RaceEventModelMapper.ToDatabase(raceEvent), cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteRaceEventAsync(Guid id, CancellationToken cancellationToken)
        {
            _dbContext.RaceEvents.Remove(new Data.Models.RaceEvent
            {
                Id = id
            });
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateRaceEventAsync(Abstractions.Models.RaceEvent raceEvent, CancellationToken cancellationToken)
        {
            var RaceEventUpdate = await _raceEventQueries.GetEventAsync(raceEvent.Id, cancellationToken);

            RaceEventUpdate.State = raceEvent.State;
            RaceEventUpdate.CityName = raceEvent.CityName;
            RaceEventUpdate.ZipCode = raceEvent.ZipCode;
            RaceEventUpdate.Address = raceEvent.Address;
            RaceEventUpdate.Country = raceEvent.Country;

            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
