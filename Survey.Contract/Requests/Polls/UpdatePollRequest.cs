namespace Survey.Contract.Requests.Polls;

public class UpdatePollRequest
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}