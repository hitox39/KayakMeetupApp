using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Data.Models;
using UserLookupService.Data.Query;
using UserLookupService.Abstractions.Interfaces.IRepo;
using FishingTournamentEvent = UserLookupService.Abstractions.Models.FishingTournamentEvent;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Data.Repository
{
    public class FishingTournamentRepository : IFishingTournamentRepository
    {


        private readonly MainContext _dbContext;
        private readonly FishingTournamentQueries _fishingEventQueries;

        public FishingTournamentRepository(MainContext dbContext, FishingTournamentQueries fishingEventQueries)
        {
            _dbContext = dbContext;
            _fishingEventQueries = fishingEventQueries;
        }

        public async Task AddEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {
            await _dbContext.FishingTournamentEvents.AddAsync(FishingTournamentModelMapper.ToDatabase(fishingTournamentEvent), cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

        }

        public async Task DeleteEventAsync(Guid id, CancellationToken cancellationToken)
        {
            _dbContext.FishingTournamentEvents.Remove(new Data.Models.FishingTournamentEvent
            {
                Id = id
            });
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        
        public async Task UpdateEventAsync(FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {
            var FishingTournamentEvent = await _fishingEventQueries.GetEventAsync(fishingTournamentEvent.Id, cancellationToken);

            FishingTournamentEvent.State = fishingTournamentEvent.State;
            FishingTournamentEvent.CityName = fishingTournamentEvent.CityName;
            FishingTournamentEvent.ZipCode = fishingTournamentEvent.ZipCode;
            FishingTournamentEvent.Address = fishingTournamentEvent.Address;
            FishingTournamentEvent.Longitude = fishingTournamentEvent.Longitude;
            FishingTournamentEvent.Latitude = fishingTournamentEvent.Latitude;
            FishingTournamentEvent.Country = fishingTournamentEvent.Country;

            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
