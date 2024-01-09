using Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class GetGameByIdQueryHandler : IRequestHandler<GetGameByIdQuery, GetGameByIdQueryResult>
{
    private readonly IRepository<Game> _repository;

    public GetGameByIdQueryHandler(IRepository<Game> repository)
    {
        _repository = repository;
    }

    public async Task<GetGameByIdQueryResult> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetGameByIdQueryResult
        {
            Id = value.Id,
            SelfMaxMultiplier = value.SelfMaxMultiplier,
            SelfMaxEarning = value.SelfMaxEarning,
            Rtp = value.Rtp,
            MaxMultiplier = value.MaxMultiplier,
            IsActive = value.IsActive,
            GameName = value.GameName,
            GameProducerId = value.GameProducerId
        };
    }
}
