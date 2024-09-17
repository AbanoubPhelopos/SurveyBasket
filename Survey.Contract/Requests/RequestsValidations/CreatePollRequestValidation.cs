namespace Survey.Contract.Requests.RequestsValidations;

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