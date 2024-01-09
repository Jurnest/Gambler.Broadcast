using Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using Gambler.Broadcast.Application.Interfaces.GameInterfaces;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class GetGameWithProducerQueryHandler : IRequestHandler<GetGameWithProducerQuery, List<GetGameWithProducerQueryResult>>
{
    private readonly IGameRepository _repository;

    public GetGameWithProducerQueryHandler(IGameRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetGameWithProducerQueryResult>> Handle(GetGameWithProducerQuery request, CancellationToken cancellationToken)
    {
        //ToDo There is difficulty in working fluently, there should be a fix.
        var values = await _repository.GetGamesWithProducer();
        return values.Select(x => new GetGameWithProducerQueryResult
        {
            Id = x.Id,
            GameName = x.GameName,
            GameProducerId = x.GameProducerId,
            IsActive = x.IsActive,
            MaxMultiplier = x.MaxMultiplier,
            Rtp = x.Rtp,
            SelfMaxEarning = x.SelfMaxEarning,
            SelfMaxMultiplier = x.SelfMaxMultiplier,
            GameProducerName = x.GameProducer.ProducerName
        }).ToList();
    }
}
