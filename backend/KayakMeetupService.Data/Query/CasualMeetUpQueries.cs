using Microsoft.EntityFrameworkCore;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using State = KayakMeetupService.Abstractions.Models.State;
using CasualMeetUpEvent = KayakMeetupService.Abstractions.Models.CasualMeetUpEvent;
using KayakMeetupService.Data.Models;
using KayakMeetupService.Abstractions;
using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Data.Query;

public class CasualMeetUpQueries : ICasualMeetUpEventQuery
{
    private readonly MainContext _dbContext;

    public CasualMeetUpQueries(MainContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IList<CasualMeetUpEvent>> GetAllEventsAsync(CancellationToken cancellationToken)
    {
        var casualMeetUpEvent = await _dbContext.CasualMeetUpEvents
            .ToListAsync(cancellationToken);

        return CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent);
    }

    public async Task<CasualMeetUpEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
    {
        var casualMeetUpEvent = await _dbContext.CasualMeetUpEvents
            .Where(x => x.Id == id)
            .SingleAsync(cancellationToken);

        return CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent);
    }

    public async Task<IList<CasualMeetUpEvent>> GetEventsByCityNameAsync(string cityName, CancellationToken cancellationToken)
    {
        var casualMeetUpEvent = await _dbContext.CasualMeetUpEvents
            .Where(x => x.CityName == cityName)
            .ToListAsync(cancellationToken);

           return CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent);
    }

    public async Task<IList<CasualMeetUpEvent>> GetEventsByCountry(string country, CancellationToken cancellationToken)
    {
        var casualMeetUpEvent = await _dbContext.CasualMeetUpEvents
             .Where(x => x.Country == country)
             .ToListAsync(cancellationToken);

             return CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent); 
    }

    public async Task<IList<CasualMeetUpEvent>> GetEventsByStateAsync(State state, CancellationToken cancellationToken)
    {
        var casualMeetUpEvent = await _dbContext.CasualMeetUpEvents
            .Where(x => x.State == state)
            .ToListAsync(cancellationToken);

            return CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent); 
    }

    public async Task<IList<CasualMeetUpEvent>> GetEventsByZipCodeAsync(int zipCode, CancellationToken cancellationToken)
    {
        var casualMeetUpEvent = await _dbContext.CasualMeetUpEvents
            .Where(x => x.ZipCode == zipCode)
            .ToListAsync(cancellationToken);

            return CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent); ;
    }

}
