namespace Survey.Contract.Poll;

public class CreatePollRequestValidation : AbstractValidator<CreatePollRequest>
{
    public CreatePollRequestValidation()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .Length(3, 100);
        
        RuleFor(x => x.Description)
            .NotEmpty().
            Length(3, 1000);
    }
}