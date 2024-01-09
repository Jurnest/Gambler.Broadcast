using Gambler.Broadcast.Application.Features.Mediator.Results.GameProducerResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.GameProducerQueries;

public class GetGameProducerByIdQuery : IRequest<GetGameProcuderByIdQueryResult>
{
    public int Id { get; set; }

    public GetGameProducerByIdQuery(int id)
    {
        Id = id;
    }
}
