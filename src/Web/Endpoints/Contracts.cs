using Educar.Backend.Application.Commands;
using Educar.Backend.Application.Commands.Contract.CreateContract;
using Educar.Backend.Application.Commands.Contract.DeleteContract;
using Educar.Backend.Application.Commands.Contract.UpdateContract;
using Educar.Backend.Application.Common.Models;
using Educar.Backend.Application.Queries.Contract;
using Educar.Backend.Domain.Enums;
using Microsoft.OpenApi.Extensions;

namespace Educar.Backend.Web.Endpoints;

public class Contracts : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization(UserRole.Admin.GetDisplayName())
            .MapPost(CreateContract)
            .MapGet(GetAllContracts)
            .MapGet(GetContract, "{id}")
            .MapPut(UpdateContract, "{id}")
            .MapDelete(DeleteContract, "{id}");
    }

    public async Task<ContractDto> GetContract(ISender sender, Guid id)
    {
        return await sender.Send(new GetContractQuery { Id = id });
    }

    public Task<IdResponseDto> CreateContract(ISender sender, CreateContractCommand command)
    {
        return sender.Send(command);
    }

    public Task<PaginatedList<ContractDto>> GetAllContracts(ISender sender,
        [AsParameters] PaginatedQuery paginatedQuery)
    {
        var query = new GetContractsPaginatedQuery
        {
            PageNumber = paginatedQuery.PageNumber,
            PageSize = paginatedQuery.PageSize
        };

        return sender.Send(query);
    }


    public async Task<IResult> DeleteContract(ISender sender, Guid id)
    {
        await sender.Send(new DeleteContractCommand(id));
        return Results.NoContent();
    }

    public async Task<IResult> UpdateContract(ISender sender, Guid id, UpdateContractCommand command)
    {
        command.Id = id;
        await sender.Send(command);
        return Results.NoContent();
    }
}