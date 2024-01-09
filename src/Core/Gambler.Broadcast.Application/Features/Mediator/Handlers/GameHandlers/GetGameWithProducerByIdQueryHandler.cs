using Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using Gambler.Broadcast.Application.Interfaces.GameInterfaces;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class GetGameWithProducerByIdQueryHandler : IRequestHandler<GetGameWithProducerByIdQuery, GetGameWithProducerByIdQueryResult>
{
    private readonly IGameRepository _repository;

    public GetGameWithProducerByIdQueryHandler(IGameRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetGameWithProducerByIdQueryResult> Handle(GetGameWithProducerByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetGameWithProducerById(request.Id);
        return new GetGameWithProducerByIdQueryResult
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
