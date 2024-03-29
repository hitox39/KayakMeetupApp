﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using KayakMeetUpService.Abstractions.Interfaces.IQuery;
using KayakMeetUpService.Abstractions.Models;
using KayakMeetUpService.Data.Models;
using FishingTournamentEvent = KayakMeetUpService.Abstractions.Models.FishingTournamentEvent;


namespace KayakMeetUpService.Data.Query
{
    public class FishingTournamentQueries : IFishingTournamentQueries
    {
        private readonly MainContext _dbContext;

        public FishingTournamentQueries(MainContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<FishingTournamentEvent>> GetAllEventsAsync(CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<FishingTournamentEvent?> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .Where(x => x.Id == id)
            .SingleOrDefaultAsync(cancellationToken);

            if (fishingTournamentEvent == null)
            {
                return null;
            }

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

        public async Task<IList<FishingTournamentEvent>> GetEventsByZipCodeAsync(string zipCode, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
            .Where(x => x.ZipCode == zipCode)
            .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent); ;
        }

        public async Task<IList<FishingTournamentEvent>> GetEventsByName(string eventName, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
             .Where(x => x.EventName == eventName)
             .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }

        public async Task<IList<FishingTournamentEvent>> GetEventsByAddress(string address, CancellationToken cancellationToken)
        {
            var fishingTournamentEvent = await _dbContext.FishingTournamentEvents
             .Where(x => x.Address == address)
             .ToListAsync(cancellationToken);

            return FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent);
        }


    }
}
