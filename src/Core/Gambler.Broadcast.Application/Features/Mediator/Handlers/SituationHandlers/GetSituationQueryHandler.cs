using Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameProducerResults;
using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.SituationHandlers;

public class GetSituationQueryHandler : IRequestHandler<GetSituationQuery, List<GetSituationQueryResult>>
{
    private readonly IRepository<Situation> _repository;

    public GetSituationQueryHandler(IRepository<Situation> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetSituationQueryResult>> Handle(GetSituationQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetSituationQueryResult
        {
            Id = x.Id,
            CashIn = x.CashIn,
            CashOut = x.CashOut,
            StartMoney = x.StartMoney
        }).ToList();
    }
}

