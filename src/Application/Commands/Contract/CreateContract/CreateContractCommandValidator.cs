using Educar.Backend.Application.Commands.Contract.CreateAccountType;
using Educar.Backend.Application.Interfaces;

namespace Educar.Backend.Application.Commands.AccountType.CreateAccountType;

public class CreateContractCommandValidator : AbstractValidator<CreateContractCommand>
{
    public CreateContractCommandValidator()
    {

        RuleFor(v => v.ClientId).NotEmpty().WithMessage("ClientId is required.");
        
        RuleFor(v => v.ContractDurationInYears)
            .GreaterThan(0).WithMessage("ContractDurationInYears must be greater than 0.");

        RuleFor(v => v.ContractSigningDate)
            .NotEmpty().WithMessage("ContractSigningDate is required.");

        RuleFor(v => v.ImplementationDate)
            .NotEmpty().WithMessage("ImplementationDate is required.");

        RuleFor(v => v.TotalAccounts)
            .GreaterThan(0).WithMessage("TotalAccounts must be greater than 0.");

        RuleFor(v => v.Status)
            .IsInEnum().WithMessage("Status must be a valid ContractStatus.");
    }
}