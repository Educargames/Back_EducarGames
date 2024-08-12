using Educar.Backend.Application.Commands.QuestStepContent.ExpectedAnswerTypes;
using Educar.Backend.Domain.Enums;

namespace Educar.Backend.Application.Commands.QuestStepContent.UpdateQuestStepContent;

public class UpdateQuestStepContentCommandValidator : AbstractValidator<UpdateQuestStepContentCommand>
{
    public UpdateQuestStepContentCommandValidator()
    {
        RuleFor(v => v.Id).NotEmpty().WithMessage("Id is required.");

        RuleFor(v => v.QuestStepContentType)
            .IsInEnum().WithMessage("QuestStepContentType is not valid.")
            .NotEqual(QuestStepContentType.None).WithMessage("QuestStepContentType is required.");

        RuleFor(v => v.QuestionType)
            .IsInEnum().WithMessage("QuestionType is not valid.")
            .NotEqual(QuestionType.None).WithMessage("QuestionType is required.");

        RuleFor(v => v.Description)
            .NotEmpty().WithMessage("Description is required.");

        RuleFor(v => v.Weight)
            .GreaterThan(0).WithMessage("Weight must be greater than 0.");

        RuleFor(v => v.ExpectedAnswers)
            .Must((command, expectedAnswers) =>
                QuestStepContentCommandValidator.ValidateExpectedAnswer(command.QuestionType,
                    expectedAnswers as IExpectedAnswer))
            .WithMessage("ExpectedAnswers is not valid for the specified QuestionType.");
    }
}