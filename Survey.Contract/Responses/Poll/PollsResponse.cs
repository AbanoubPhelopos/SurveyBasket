﻿namespace Survey.Contract.Responses.Poll;

public class PollsResponse
{
    public IEnumerable<PollResponse> Items { get; init; } = Enumerable.Empty<PollResponse>();
}
