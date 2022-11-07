using Microsoft.EntityFrameworkCore;
using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Models;
using UserLookupService.Data.Models;


namespace UserLookupService.Data.Query;

    public class RaceEventQueries : IRaceEventQuery
    {
        private readonly MainContext _dbContext;

        public RaceEventQueries(MainContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<Abstractions.RaceEvent>> GetAllEventsAsync(CancellationToken cancellationToken)
        {
            var raceEvent = await _dbContext.RaceEvents
                .ToListAsync(cancellationToken);

            return RaceEventModelMapper.ToBusiness(raceEvent);
        }

    public async Task<Abstractions.RaceEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
     {
            var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.Id == id)
            .SingleAsync(cancellationToken);

            return RaceEventModelMapper.ToBusiness(raceEvent);
        }

    public async Task<IList<Abstractions.RaceEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.CityName == CityName)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.RaceEvent>> GetEventByCountry(string Country, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                 .Where(x => x.Country == Country)
                 .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.RaceEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.State == state)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

    public async Task<IList<Abstractions.RaceEvent>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken)
    {
        var raceEvent = await _dbContext.RaceEvents
                .Where(x => x.ZipCode == ZipCode)
                .ToListAsync(cancellationToken);

        return RaceEventModelMapper.ToBusiness(raceEvent);
    }

                  

    
}
