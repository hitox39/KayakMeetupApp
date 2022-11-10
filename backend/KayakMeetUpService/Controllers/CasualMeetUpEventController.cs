using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KayakMeetUpService.Abstractions;
using KayakMeetUpService.Data.Models;
using KayakMeetUpService.Domains;

namespace KayakMeetUpService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasualMeetUpEventController : ControllerBase
    {

        private readonly ILogger<CasualMeetUpEventController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public CasualMeetUpEventController(ILogger<CasualMeetUpEventController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetEventById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var getEventUseCase = _serviceProvider.GetRequiredService<CasualMeetUpUseCases>();

            var user = await getEventUseCase.GetEventAsync(id, cancellationToken);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent([FromBody] AddCasualMeetUpEvent addCasualMeetUpEvent, CancellationToken cancellationToken)
        {
            var addEventUseCase = _serviceProvider.GetRequiredService<CasualMeetUpUseCases>();

            var createEvent = await addEventUseCase.AddEventAsync(CasualMeetUpModelMapper.ToBusiness(addCasualMeetUpEvent), cancellationToken);

            return Created($"{createEvent.Id}", createEvent);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCasualMeetUpEventAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var deleteEventUseCase = _serviceProvider.GetRequiredService<CasualMeetUpUseCases>();

            await deleteEventUseCase.DeleteCasualMeetUpEventAsync(id, cancellationToken);

            return NoContent();

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCasualMeetUpEventAsync([FromBody] AddCasualMeetUpEvent casualMeetUpEvent, CancellationToken cancellationToken)
        {

            var updateEventUseCase = _serviceProvider.GetRequiredService<CasualMeetUpUseCases>();

            await updateEventUseCase.UpdateCasualMeetUpEventAsync(CasualMeetUpModelMapper.ToBusiness(casualMeetUpEvent), cancellationToken);

            return Ok();
        }
    }
}
