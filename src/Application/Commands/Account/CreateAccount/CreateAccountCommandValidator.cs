using Educar.Backend.Application.Common.Interfaces;

namespace Educar.Backend.Application.Commands.Account.CreateAccount;

public class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateAccountCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Name)
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.")
            .NotEmpty().WithMessage("Name is required.");

        RuleFor(v => v.Email)
            .MaximumLength(100).WithMessage("Email must not exceed 100 characters.")
            .NotEmpty().WithMessage("Email is required.")
            .MustAsync(BeUniqueTitle).WithMessage("'{PropertyName}' must be unique.")
            .EmailAddress().WithMessage("A valid email is required.");

        RuleFor(v => v.RegistrationNumber)
            .NotEmpty().WithMessage("Registration number is required.");

        RuleFor(v => v.AverageScore)
            .InclusiveBetween(0, 999.99m).WithMessage("Average score must be between 0 and 999.99.")
            .PrecisionScale(5, 2, true)
            .WithMessage("Event average score must have up to 5 digits in total, with 2 decimal places.");

        RuleFor(v => v.EventAverageScore)
            .InclusiveBetween(0, 999.99m).WithMessage("Event average score must be between 0 and 999.99.")
            .PrecisionScale(5, 2, true)
            .WithMessage("Event average score must have up to 5 digits in total, with 2 decimal places.");

        RuleFor(v => v.Stars)
            .InclusiveBetween(0, 5).WithMessage("Stars must be between 0 and 5.");

        RuleFor(v => v.ClientId)
            .NotEmpty().WithMessage("Client ID is required.");

        RuleFor(v => v.Role)
            .NotEmpty().WithMessage("Role is required.")
            .IsInEnum().WithMessage("Role must be a valid enum value.");
    }

    public async Task<bool> BeUniqueTitle(string email, CancellationToken cancellationToken)
    {
        return await _context.Accounts
            .AllAsync(l => l.Email != email, cancellationToken);
    }
}