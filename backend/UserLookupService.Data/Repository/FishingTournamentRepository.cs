using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using KayakMeetupService.Data.Models;
using KayakMeetupService.Data.Query;
using KayakMeetupService.Abstractions.Interfaces.IRepo;
using FishingTournamentEvent = KayakMeetupService.Abstractions.Models.FishingTournamentEvent;
using KayakMeetupService.Abstractions.Models;

namespace KayakMeetupService.Data.Repository
{
    public class FishingTournamentRepository : IFishingTournamentRepository
    {


        private readonly MainContext _dbContext;
        private readonly FishingEventQueries _fishingEventQueries;

        public FishingTournamentRepository(MainContext dbContext, FishingEventQueries fishingEventQueries)
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
