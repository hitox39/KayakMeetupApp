﻿using UserLookupService.Abstractions.Models;

namespace UserLookupService.Abstractions.Interfaces.IQuery
{
    public interface IDashboardQuery
    {
        Task<List<RaceEvent>> GetAllRaceEvents();
        Task<List<CasualMeetUpEvent>> GetAllCasualMeetUpEvents();
        Task<List<FishingTournamentEvent>> GetAllFishingTournamentEvents();
        Task<User> GetById(Guid id);
    }
}