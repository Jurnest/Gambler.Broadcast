using Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using Gambler.Broadcast.Application.Interfaces.SituationInterfaces;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.SituationHandlers;

public class GetSituationLatestQueryHandler : IRequestHandler<GetSituationLatestQuery, GetSituationLatestQueryResult>
{
    private readonly ISituationRepository _repository;

    public GetSituationLatestQueryHandler(ISituationRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetSituationLatestQueryResult> Handle(GetSituationLatestQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetLatestSituation();
        return new GetSituationLatestQueryResult
        {
            Id = value.Id,
            StartMoney = value.StartMoney,
            CashIn = value.CashIn,
            CashOut = value.CashOut
        };
    }
}
