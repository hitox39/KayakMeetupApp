using KayakMeetUpService.Abstractions.Interfaces.IRepo;
using KayakMeetUpService.Data.Models;
using KayakMeetUpService.Abstractions.Models;
using KayakMeetUpService.Abstractions.Interfaces.IQuery;

namespace KayakMeetUpService.Data.Repository
{
    public class FishingTournamentRepository : IFishingTournamentRepository
    {


        private readonly MainContext _dbContext;
        private readonly IFishingTournamentQueries _fishingEventQueries;

        public FishingTournamentRepository(MainContext dbContext, IFishingTournamentQueries fishingEventQueries)
        {
            _dbContext = dbContext;
            _fishingEventQueries = fishingEventQueries;
        }

        public async Task AddEventAsync(Abstractions.Models.FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
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

        
        public async Task UpdateEventAsync(Abstractions.Models.FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
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
