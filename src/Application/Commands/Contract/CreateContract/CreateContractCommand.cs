using Educar.Backend.Application.Common.Interfaces;
using Educar.Backend.Domain.Enums;

namespace Educar.Backend.Application.Commands.Contract.CreateContract;

public record CreateContractCommand : IRequest<IdResponseDto>
{
    public CreateContractCommand(Guid clientId, Guid gameId)
    {
        ClientId = clientId;
        GameId = gameId;
    }

    public int ContractDurationInYears { get; init; }
    public DateTimeOffset ContractSigningDate { get; init; }
    public DateTimeOffset ImplementationDate { get; init; }
    public int TotalAccounts { get; init; }
    public int? RemainingAccounts { get; init; }
    public string? DeliveryReport { get; init; }
    public ContractStatus Status { get; init; }
    public Guid ClientId { get; init; }
    public Guid GameId { get; init; }
}

public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, IdResponseDto>
{
    private readonly IApplicationDbContext _context;

    public CreateContractCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IdResponseDto> Handle(CreateContractCommand request, CancellationToken cancellationToken)
    {
        var client = await _context.Clients.FindAsync([request.ClientId], cancellationToken: cancellationToken);
        // Guard.Against.Null(client, message: $"Client {request.ClientId} not found.");
        if (client == null) throw new NotFoundException(nameof(Client), request.ClientId.ToString());

        var game = await _context.Games.FindAsync([request.GameId], cancellationToken: cancellationToken);
        if (game == null) throw new NotFoundException(nameof(Game), request.GameId.ToString());

        var entity = new Domain.Entities.Contract(
            request.ContractDurationInYears,
            request.ContractSigningDate,
            request.ImplementationDate,
            request.TotalAccounts,
            request.Status
        )
        {
            RemainingAccounts = request.RemainingAccounts ?? request.TotalAccounts,
            DeliveryReport = request.DeliveryReport,
            Client = client,
            Game = game
        };

        _context.Contracts.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return new IdResponseDto(entity.Id);
    }
}