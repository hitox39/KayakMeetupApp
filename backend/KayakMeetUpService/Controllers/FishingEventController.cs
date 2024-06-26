 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KayakMeetUpService.Abstractions;
using KayakMeetUpService.Data.Models;
using KayakMeetUpService.Domains;

namespace KayakMeetUpService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishingEventController : ControllerBase
    {

        private readonly ILogger<FishingEventController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public FishingEventController(ILogger<FishingEventController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetEventById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var getEventUseCase = _serviceProvider.GetRequiredService<FishingTournamentEventUseCases>();

            var user = await getEventUseCase.GetEventAsync(id, cancellationToken);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent([FromBody] AddFishingTournamentEvent addFishingTournamentEvent, CancellationToken cancellationToken)
        {
            var addEventUseCase = _serviceProvider.GetRequiredService<FishingTournamentEventUseCases>();

            var createEvent = await addEventUseCase.AddEventAsync(FishingTournamentModelMapper.ToBusiness(addFishingTournamentEvent), cancellationToken);

            return Created($"{createEvent.Id}", createEvent);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEventAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var deleteEventUseCase = _serviceProvider.GetRequiredService<FishingTournamentEventUseCases>();

            await deleteEventUseCase.DeleteEventAsync(id, cancellationToken);

            return NoContent();

        }

        [HttpPut]
        public async Task<IActionResult> UpdateEvent([FromBody] AddFishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {

            var updateEventUseCase = _serviceProvider.GetRequiredService<FishingTournamentEventUseCases>();

            await updateEventUseCase.UpdateEventAsync(FishingTournamentModelMapper.ToBusiness(fishingTournamentEvent), cancellationToken);

            return Ok();
        }
    }
}
