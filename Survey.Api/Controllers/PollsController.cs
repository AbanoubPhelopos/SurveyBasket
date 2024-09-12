using Survey.Api.Mapping;
using Survey.Application.Services;
using Survey.Contract.Requests.Polls;

namespace Survey.Api.Controllers;
public class PollsController(IPollServices services) : BaseApiController
{
    [HttpGet("")]
    public IActionResult GetAll()
    {
        var pollResponse = services.GetAll().MapToResponse();
        return Ok(pollResponse);
    }
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var poll = services.Get(id);
        return poll is null ? NotFound() : Ok(poll.MapToResponse());
    }

    [HttpPost("")]
    public IActionResult Add(CreatePollRequest request)
    {
        var newRequest = services.Add(request.MapToPoll());
        return CreatedAtAction(nameof(Get), new {id = newRequest.Id}, newRequest);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, UpdatePollRequest request)
    {
        var isUpdated = services.Update(id, request.MapToPoll(id));
        if (!isUpdated)
            return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var sDeleted = services.Delete(id);
        if (!sDeleted)
            return NotFound();
        return NoContent();
    }
    
}