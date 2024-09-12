namespace Survey.Application.Services;

public class PollServices : IPollServices
{
    List<Poll> _polls = new List<Poll>
    {
        new Poll { Id = Guid.NewGuid(), Title = "Favorite Movie", Description = "Vote for your favorite movie." },
        new Poll { Id = Guid.NewGuid(), Title = "Best Vacation Destination", Description = "Choose the best place to go on vacation." },
        new Poll { Id = Guid.NewGuid(), Title = "Favorite Sport", Description = "Vote for your favorite sport." },
        new Poll { Id = Guid.NewGuid(), Title = "Best Programming Language", Description = "Which programming language do you prefer?" },
        new Poll { Id = Guid.NewGuid(), Title = "Favorite Food", Description = "What is your favorite food?" }
    };
    public List<Poll> GetAll() => _polls;
    public Poll? Get(Guid id) => _polls.SingleOrDefault(p => p.Id == id);
}