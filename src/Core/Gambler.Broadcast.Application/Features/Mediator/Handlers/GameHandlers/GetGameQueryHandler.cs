using Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class GetGameQueryHandler : IRequestHandler<GetGameQuery, List<GetGameQueryResult>>
{
    private readonly IRepository<Game> _repository;

    public GetGameQueryHandler(IRepository<Game> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetGameQueryResult>> Handle(GetGameQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetGameQueryResult
        {
            Id = x.Id,
            GameName = x.GameName,
            GameProducerId = x.GameProducerId,
            IsActive = x.IsActive,
            MaxMultiplier = x.MaxMultiplier,
            Rtp = x.Rtp,
            SelfMaxEarning = x.SelfMaxEarning,
            SelfMaxMultiplier = x.SelfMaxMultiplier
        }).ToList();
    }
}