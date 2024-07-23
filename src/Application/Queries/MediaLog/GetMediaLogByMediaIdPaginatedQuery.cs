using Educar.Backend.Application.Common.Interfaces;
using Educar.Backend.Application.Common.Mappings;
using Educar.Backend.Application.Common.Models;

namespace Educar.Backend.Application.Queries.MediaLog;

public record GetMediaLogByMediaIdPaginatedQuery(Guid MediaId) : IRequest<PaginatedList<MediaLogDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetMediaLogByMediaIdPaginatedQueryHandler : IRequestHandler<GetMediaLogByMediaIdPaginatedQuery,
    PaginatedList<MediaLogDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetMediaLogByMediaIdPaginatedQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<MediaLogDto>> Handle(GetMediaLogByMediaIdPaginatedQuery request,
        CancellationToken cancellationToken)
    {
        return await _context.MediaLogs
            .Where(x => x.MediaId == request.MediaId)
            .ProjectTo<MediaLogDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}