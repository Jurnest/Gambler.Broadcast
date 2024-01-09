using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;

public class GetGameWithProducerQuery : IRequest<List<GetGameWithProducerQueryResult>>
{
}

public class GetSelectedGameWithProducerQuery : IRequest<GetSelectedGameWithProducerQueryResult>
{
}
