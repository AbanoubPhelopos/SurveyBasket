namespace Survey.Contract.Requests.Polls;

public class CreatePollRequest
{
    // TODO: after connecting to a database delete Id from request contract and contract mapping 
    public required int Id { get; set; }
    
    public required string Title { get; set; }
    public required string Description { get; set; }
}