using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLookupService.Abstractions.Interfaces.IQuery;
using UserLookupService.Abstractions.Models;

namespace UserLookupService.Data.Query
{
    public class CasualMeetUpQueries : ICasualMeetUpEventQuery
    {
        public Task<IList<CasualMeetUpEvent>> GetAllEventsAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CasualMeetUpEvent> GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CasualMeetUpEvent>> GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CasualMeetUpEvent>> GetEventByCuntry(string Country, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CasualMeetUpEvent>> GetEventByStateAsync(State state, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CasualMeetUpEvent>> GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IList<Event>> IEventQuery.GetAllEventsAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<Event> IEventQuery.GetEventAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IList<Event>> IEventQuery.GetEventByCityNameAsync(string CityName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IList<Event>> IEventQuery.GetEventByCuntry(string Country, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IList<Event>> IEventQuery.GetEventByStateAsync(State state, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IList<Event>> IEventQuery.GetEventByZipCodeAsync(int ZipCode, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
