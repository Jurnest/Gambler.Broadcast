using Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.SituationHandlers;

public class GetSituationByIdQueryHandler : IRequestHandler<GetSituationByIdQuery, GetSituationByIdQueryResult>
{
    private readonly IRepository<Situation> _repository;

    public GetSituationByIdQueryHandler(IRepository<Situation> repository)
    {
        _repository = repository;
    }

    public async Task<GetSituationByIdQueryResult> Handle(GetSituationByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetSituationByIdQueryResult
        {
            Id = value.Id,
            StartMoney = value.StartMoney,
            CashIn = value.CashIn,
            CashOut = value.CashOut
        };
    }
}
