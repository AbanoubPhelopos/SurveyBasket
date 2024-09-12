using Microsoft.AspNetCore.Mvc;
using Survey.Api.Models;

namespace Survey.Api.Controllers;

public class PollsController : BaseApiController
{

    private readonly List<Poll> _poll = [
        new Poll
        { Id = 1, Title = "ll", Description = "lol1" },
        new Poll
        { Id = 2, Title = "ll", Description = "lol2" },
        new Poll
        { Id = 3, Title = "ll", Description = "lol3" },
    ];

    [HttpGet("")]
    public IActionResult GetAll()
    {
        return Ok(_poll);
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var poll = _poll.SingleOrDefault(p => p.Id == id);
        return poll is null ? NotFound() : Ok(poll);
    }
}