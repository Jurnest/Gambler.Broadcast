using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;

public class GetGameQuery : IRequest<List<GetGameQueryResult>>
{
}
