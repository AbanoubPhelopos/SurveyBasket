namespace Survey.Contract.Poll;

public class CreatePollRequest
{
    public required string Title { get; init; }
    public required string Description { get; init; }
}