using Educar.Backend.Application.Common.Interfaces;

namespace Educar.Backend.Application.Commands.Game.UpdateGame;

public class UpdateGameCommandValidator : AbstractValidator<UpdateGameCommand>
{
    private readonly IApplicationDbContext _context;


    public UpdateGameCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.")
            .MustAsync(BeUniqueTitle).WithMessage("'{PropertyName}' must be unique.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required.");

        RuleFor(x => x.Lore)
            .NotEmpty().WithMessage("Lore is required.");

        RuleFor(x => x.Purpose)
            .NotEmpty().WithMessage("Purpose is required.")
            .MaximumLength(255).WithMessage("Purpose must not exceed 255 characters.");
    }

    public async Task<bool> BeUniqueTitle(string name, CancellationToken cancellationToken)
    {
        return await _context.Games
            .AllAsync(l => l.Name != name, cancellationToken);
    }
}