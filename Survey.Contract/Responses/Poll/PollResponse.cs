namespace Survey.Contract.Responses.Poll;

public class PollResponse
{
    public required Guid Id { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
}