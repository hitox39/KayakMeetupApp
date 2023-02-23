using Microsoft.EntityFrameworkCore;
using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Models;
using KayakMeetUpService.Data.Models;
using System.Diagnostics.Metrics;


namespace KayakMeetUpService.Data.Query;

    public class RaceEventQueries : IRaceEventQuery
    {
        private readonly MainContext _dbContext;

        public RaceEventQueries(MainContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<Abstractions.Models.RaceEvent>> GetAllEventsAsync(CancellationToken cancellationToken)
        {
            var raceEvent = await _dbContext.RaceEvents
                .ToListAsync(cancellationToken);

            return RaceEventModelMapper.ToBusiness(raceEvent);
        }

    public async Task<Abstractions.Models.RaceEvent?> GetEventAsync(Guid id, CancellationToken cancellationToken)
     {
            var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.Id == id)
            .SingleOrDefaultAsync(cancellationToken);

        if (raceEvent == null)
        {
            return null;
        }

        return RaceEventModelMapper.ToBusiness(raceEvent);
        }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByAddress(string Address, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.Address == Address)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.CityName == CityName)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByCountry(string Country, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                 .Where(x => x.Country == Country)
                 .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByName(string eventName, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                 .Where(x => x.EventName == eventName)
                 .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByPrizePool(int Prizepool, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                 .Where(x => x.PrizePool == Prizepool)
                 .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.State == state)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.Models.RaceEvent>> GetEventByZipCodeAsync(string ZipCode, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.ZipCode == ZipCode)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

                  

    
}
