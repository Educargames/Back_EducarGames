using Educar.Backend.Application.Common.Interfaces;
using Educar.Backend.Application.Common.Mappings;
using Educar.Backend.Application.Common.Models;

namespace Educar.Backend.Application.Queries.Account;

public record GetAccountsPaginatedQuery : IRequest<PaginatedList<AccountDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetAccountsPaginatedQueryHandler : IRequestHandler<GetAccountsPaginatedQuery, PaginatedList<AccountDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAccountsPaginatedQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<AccountDto>> Handle(GetAccountsPaginatedQuery request,
        CancellationToken cancellationToken)
    {
        return await _context.Accounts
            .OrderBy(x => x.Email)
            .ProjectTo<AccountDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}