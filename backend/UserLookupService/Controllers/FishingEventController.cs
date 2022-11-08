using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserLookupService.Abstractions;
using UserLookupService.Data.Models;
using UserLookupService.Domains;

namespace UserLookupService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishingEventController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public FishingEventController(ILogger<UserController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetEventById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var getEventUseCase = _serviceProvider.GetRequiredService<FishingEventUseCases>();

            var user = await getEventUseCase.GetEventAsync(id, cancellationToken);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent([FromBody] AddFishingTournamentEvent addFishingTournamentEvent, CancellationToken cancellationToken)
        {
            var addEventUseCase = _serviceProvider.GetRequiredService<FishingEventUseCases>();

            var createEvent = await addEventUseCase.AddEventAsync(FishingTournamentModelMapper.ToBusiness(addFishingTournamentEvent), cancellationToken);

            return Created($"{createEvent.Id}", createEvent);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEventAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var deleteEventUseCase = _serviceProvider.GetRequiredService<FishingEventUseCases>();

            await deleteEventUseCase.DeleteEventAsync(id, cancellationToken);

            return NoContent();

        }

        [HttpPut]
        public async Task<IActionResult> UpdateEvent([FromBody] Data.Models.FishingTournamentEvent fishingTournamentEvent, CancellationToken cancellationToken)
        {

            var updateEventUseCase = _serviceProvider.GetRequiredService<FishingEventUseCases>();

            var updatedEvent = await updateEventUseCase.UpdateEventAsync(fishingTournamentEvent, cancellationToken);

            return Ok();
        }
    }
}
