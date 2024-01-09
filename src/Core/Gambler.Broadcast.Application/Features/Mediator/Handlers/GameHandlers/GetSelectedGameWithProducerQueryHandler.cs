using Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using Gambler.Broadcast.Application.Interfaces.GameInterfaces;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class GetSelectedGameWithProducerQueryHandler : IRequestHandler<GetSelectedGameWithProducerQuery, GetSelectedGameWithProducerQueryResult>
{
    private readonly IGameRepository _repository;

    public GetSelectedGameWithProducerQueryHandler(IGameRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetSelectedGameWithProducerQueryResult> Handle(GetSelectedGameWithProducerQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetSelectedGameWithProducer();
        return new GetSelectedGameWithProducerQueryResult
        {
            Id = value.Id,
            SelfMaxMultiplier = value.SelfMaxMultiplier,
            SelfMaxEarning = value.SelfMaxEarning,
            Rtp = value.Rtp,
            MaxMultiplier = value.MaxMultiplier,
            IsActive = value.IsActive,
            GameName = value.GameName,
            GameProducerId = value.GameProducerId,
            GameProducerName = value.GameProducer.ProducerName
        };
    }
}
