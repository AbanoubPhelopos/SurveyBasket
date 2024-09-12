using Survey.Api.Mapping;
using Survey.Application.Services;

namespace Survey.Api.Controllers;
public class PollsController : BaseApiController
{
    private readonly IPollServices _services;

    public PollsController(IPollServices services)
    {
        _services = services;
    }

    [HttpGet("")]
    public IActionResult GetAll()
    {
        var pollResponse = _services.GetAll().MapToResponse();
        return Ok(pollResponse);
    }
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var poll = _services.Get(id);
        return poll is null ? NotFound() : Ok(poll.MapToResponse());
    }
}