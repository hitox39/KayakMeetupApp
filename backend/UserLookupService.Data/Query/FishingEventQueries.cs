using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using KayakMeetupService.Abstractions.Interfaces.IQuery;
using KayakMeetupService.Abstractions.Models;
using KayakMeetupService.Data.Models;
using FishingTournamentEvent = KayakMeetupService.Abstractions.Models.FishingTournamentEvent;


namespace KayakMeetupService.Data.Query
{
    internal class FishingEventQueries : IFishingTournamentQueries
    {
        private readonly MainContext _dbContext;

        public FishingEventQueries(MainContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<FishingTournamentEvent>> GetAllEventsAsync(CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<FishingTournamentEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .Where(x => x.Id == id)
            .SingleAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<IList<FishingTournamentEvent>> GetEventsByCityNameAsync(string cityName, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .Where(x => x.CityName == cityName)
            .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<IList<FishingTournamentEvent>> GetEventsByCountry(string country, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
             .Where(x => x.Country == country)
             .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<IList<FishingTournamentEvent>> GetEventsByStateAsync(State state, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .Where(x => x.State == state)
            .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<IList<FishingTournamentEvent>> GetEventsByZipCodeAsync(int zipCode, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .Where(x => x.ZipCode == zipCode)
            .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent); ;
        }
    }
}
