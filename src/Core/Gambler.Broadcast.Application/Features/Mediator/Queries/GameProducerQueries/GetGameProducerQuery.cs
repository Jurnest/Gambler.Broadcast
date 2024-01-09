using Gambler.Broadcast.Application.Features.Mediator.Results.GameProducerResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.GameProducerQueries;

public class GetGameProducerQuery : IRequest<List<GetGameProcuderQueryResult>>
{
}
