namespace Survey.Contract.Responses.Poll;

public class PollResponse
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
}