using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceEvent = KayakMeetupService.Abstractions.RaceEvent;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Data.Models;
using KayakMeetupService.Data.Query;
using KayakMeetupService.Abstractions.Models;


namespace KayakMeetupService.Data.Repository
{
    public class RaceEventRepository : IRaceEventRepository
    {
        private readonly MainContext _dbContext;
        private readonly RaceEventQueries _raceEventQueries;

        public RaceEventRepository(MainContext dbContext, RaceEventQueries raceEventQueries)
        {
            _dbContext = dbContext;
            _raceEventQueries = raceEventQueries;
        }
        public async Task AddAsync(RaceEvent raceEvent, CancellationToken cancellationToken)
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

        public async Task UpdateRaceEventAsync(RaceEvent raceEvent, CancellationToken cancellationToken)
        {
            var RaceEventUpdate = await _raceEventQueries.GetEventAsync(raceEvent.Id, cancellationToken);

            RaceEventUpdate.State = raceEvent.State;
            RaceEventUpdate.CityName = raceEvent.CityName;
            RaceEventUpdate.ZipCode = raceEvent.ZipCode;
            RaceEventUpdate.Address = raceEvent.Address;
            RaceEventUpdate.Longitude = raceEvent.Longitude;
            RaceEventUpdate.Latitude = raceEvent.Latitude;
            RaceEventUpdate.Country = raceEvent.Country;

            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
