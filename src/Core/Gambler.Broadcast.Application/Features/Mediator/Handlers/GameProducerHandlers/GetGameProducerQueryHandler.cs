using Gambler.Broadcast.Application.Features.Mediator.Queries.GameProducerQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameProducerResults;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameProducerHandlers;

public class GetGameProducerQueryHandler : IRequestHandler<GetGameProducerQuery, List<GetGameProcuderQueryResult>>
{
    private readonly IRepository<GameProducer> _repository;

    public GetGameProducerQueryHandler(IRepository<GameProducer> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetGameProcuderQueryResult>> Handle(GetGameProducerQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetGameProcuderQueryResult
        {
            Id = x.Id,
            ProducerName = x.ProducerName
        }).ToList();
    }
}
