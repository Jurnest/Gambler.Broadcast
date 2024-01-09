using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;

public class GetSituationByIdQuery : IRequest<GetSituationByIdQueryResult>
{
    public int Id { get; set; }

    public GetSituationByIdQuery(int id)
    {
        Id = id;
    }
}
