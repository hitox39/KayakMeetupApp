using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLookupService.Abstractions.Interfaces.IRepo;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Data.Repository
{
    internal class CasualMeetupRepository : ICasualMeetUpEventRepository

    {


        public Task<CasualMeetUpEvent> AddAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCasualMeetUpEventAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CasualMeetUpEvent> UpdateCasualMeetUpEventAsync(CasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
