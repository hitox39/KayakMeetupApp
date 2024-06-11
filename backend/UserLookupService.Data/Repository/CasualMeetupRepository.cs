﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Data.Models;
using UserLookupService.Data.Query;
using CasualMeetUpEvent = UserLookupService.Abstractions.Models.CasualMeetUpEvent;

namespace UserLookupService.Data.Repository
{
    public class CasualMeetupRepository : ICasualMeetUpEventRepository

    {
        private readonly MainContext _dbContext;
        private readonly CasualMeetUpQueries _casualMeetUpQueries;

        public CasualMeetupRepository(MainContext dbContext, CasualMeetUpQueries casualMeetUpQueries)
        {
            _dbContext = dbContext;
            _casualMeetUpQueries = casualMeetUpQueries;
        }

        public async Task AddAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            await _dbContext.CasualMeetUpEvents.AddAsync(CasualMeetUpModelMapper.ToDatabase(casualMeetUpEvent), cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

        }

        public async Task DeleteCasualMeetUpEventAsync(Guid id, CancellationToken cancellationToken)
        {
            _dbContext.CasualMeetUpEvents.Remove(new Data.Models.CasualMeetUpEvent
            {
                Id = id
            });
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            var CasualMeetUpdate = await _casualMeetUpQueries.GetEventAsync(casualMeetUpEvent.Id, cancellationToken);

            CasualMeetUpdate.State = casualMeetUpEvent.State;
            CasualMeetUpdate.CityName = casualMeetUpEvent.CityName;
            CasualMeetUpdate.ZipCode = casualMeetUpEvent.ZipCode;
            CasualMeetUpdate.Address = casualMeetUpEvent.Address;
            CasualMeetUpdate.Longitude = casualMeetUpEvent.Longitude;
            CasualMeetUpdate.Latitude = casualMeetUpEvent.Latitude;
            CasualMeetUpdate.Country = casualMeetUpEvent.Country;

            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}