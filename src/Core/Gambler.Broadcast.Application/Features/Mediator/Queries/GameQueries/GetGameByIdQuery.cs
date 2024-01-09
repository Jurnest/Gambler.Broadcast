using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;

public class GetGameByIdQuery : IRequest<GetGameByIdQueryResult>
{
    public int Id { get; set; }

    public GetGameByIdQuery(int id)
    {
        Id = id;
    }
}