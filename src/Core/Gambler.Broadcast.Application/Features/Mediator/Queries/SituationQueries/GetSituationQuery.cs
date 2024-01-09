using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;

public class GetSituationQuery : IRequest<List<GetSituationQueryResult>>
{
}