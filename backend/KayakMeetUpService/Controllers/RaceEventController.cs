using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KayakMeetUpService.Abstractions;
using KayakMeetUpService.Data.Models;
using KayakMeetUpService.Domains;

namespace KayakMeetUpService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceEventController : ControllerBase
    {

        private readonly ILogger<RaceEventController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public RaceEventController(ILogger<RaceEventController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetEventById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var getEventUseCase = _serviceProvider.GetRequiredService<RaceEventUseCases>();

            var user = await getEventUseCase.GetEventAsync(id, cancellationToken);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] AddRaceEvent addRaceEvent, CancellationToken cancellationToken)
        {
            var addEventUseCase = _serviceProvider.GetRequiredService<RaceEventUseCases>();

            var createEvent = await addEventUseCase.AddAsync(RaceEventModelMapper.ToBusiness(addRaceEvent), cancellationToken);

            return Created($"{createEvent.Id}", createEvent);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRaceEventAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var deleteEventUseCase = _serviceProvider.GetRequiredService<RaceEventUseCases>();

            await deleteEventUseCase.DeleteRaceEventAsync(id, cancellationToken);

            return NoContent();

        }

        [HttpPut]
        public async Task<IActionResult> UpdateRaceEvent([FromBody] AddRaceEvent raceEvent, CancellationToken cancellationToken)
        {

            var updateEventUseCase = _serviceProvider.GetRequiredService<RaceEventUseCases>();

            await updateEventUseCase.UpdateRaceEventAsync(RaceEventModelMapper.ToBusiness(raceEvent), cancellationToken);

            return Ok();
        }
    }
}
