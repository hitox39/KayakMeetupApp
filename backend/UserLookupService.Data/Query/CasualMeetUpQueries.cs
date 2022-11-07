using Microsoft.EntityFrameworkCore;
using UserLookupService.Abstractions.Interfaces.IQuery;
using State = UserLookupService.Abstractions.Models.State;
using CasualMeetUpEvent = UserLookupService.Abstractions.Models.CasualMeetUpEvent;
using UserLookupService.Data.Models;
using UserLookupService.Abstractions;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Data.Query;

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
