using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;

public class GetGameWithProducerByIdQuery : IRequest<GetGameWithProducerByIdQueryResult>
{
    public int Id { get; set; }

    public GetGameWithProducerByIdQuery(int id)
    {
        Id = id;
    }
}
