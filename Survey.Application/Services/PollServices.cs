namespace Survey.Application.Services;

public class PollServices : IPollServices
{
    private static List<Poll> _polls = new List<Poll>
    {
        new Poll { Id = Guid.NewGuid(), Title = "Favorite Movie", Description = "Vote for your favorite movie." },
        new Poll { Id = Guid.NewGuid(), Title = "Best Vacation Destination", Description = "Choose the best place to go on vacation." },
        new Poll { Id = Guid.NewGuid(), Title = "Favorite Sport", Description = "Vote for your favorite sport." },
        new Poll { Id = Guid.NewGuid(), Title = "Best Programming Language", Description = "Which programming language do you prefer?" },
        new Poll { Id = Guid.NewGuid(), Title = "Favorite Food", Description = "What is your favorite food?" }
    };
    public List<Poll> GetAll() => _polls;
    public Poll? Get(Guid id) => _polls.SingleOrDefault(p => p.Id == id);
    public Poll Add(Poll request)
    {
        _polls.Add(request);
        return request;
    }

    public bool Update(Guid id, Poll request)
    {
        var currentPoll = Get(id);

        if (currentPoll is null)
            return false;
        currentPoll.Title = request.Title;
        currentPoll.Description = request.Description;
        return true;
    }

    public bool Delete(Guid id)
    {
        var poll = Get(id);

        if (poll is null)
            return false;
        _polls.Remove(poll);
        return true;
    }
}