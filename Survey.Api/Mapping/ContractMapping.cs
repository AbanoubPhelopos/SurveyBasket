﻿namespace Survey.Api.Mapping;
public static class ContractMapping
{
    
    public static Poll MapToPoll(this CreatePollRequest request,Guid? id = null)
    {
        return new Poll()
        {
            Id = id ?? Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description
        };
    }
    public static PollResponse MapToResponse(this Poll poll)
    {
        return new PollResponse()
        {
            Id=poll.Id,
            Title = poll.Title,
            Description = poll.Description
        };
    }
    public static PollsResponse MapToResponse(this IEnumerable<Poll> polls)
    {
        return new PollsResponse()
        {
            Items = polls.Select(MapToResponse)
        };
    }
}