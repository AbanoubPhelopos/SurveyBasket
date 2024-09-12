namespace Survey.Api.Controllers;
public class PollsController : BaseApiController
{

    private readonly List<Poll> _poll = [
        new Poll
        {  Title = "ll", Description = "lol1" },
        new Poll
        { Title = "ll", Description = "lol2" },
        new Poll
        { Title = "ll", Description = "lol3" },
    ];

    [HttpGet("")]
    public IActionResult GetAll()
    {
        return Ok(_poll);
    }
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var poll = _poll.SingleOrDefault(p => p.Id == id);
        return poll is null ? NotFound() : Ok(poll);
    }
}