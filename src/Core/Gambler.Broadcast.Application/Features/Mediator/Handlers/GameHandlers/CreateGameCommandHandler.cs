using Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class CreateGameCommandHandler : IRequestHandler<CreateGameCommand>
{
    private readonly IRepository<Game> _repository;

    public CreateGameCommandHandler(IRepository<Game> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateGameCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Game
        {
            GameProducerId = request.GameProducerId,
            GameName = request.GameName,
            IsActive = request.IsActive,
            MaxMultiplier = request.MaxMultiplier,
            Rtp = request.Rtp,
            SelfMaxEarning = request.SelfMaxEarning,
            SelfMaxMultiplier = request.SelfMaxMultiplier
        });
    }
}