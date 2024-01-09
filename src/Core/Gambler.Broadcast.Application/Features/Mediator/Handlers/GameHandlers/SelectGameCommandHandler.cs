using Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;
using Gambler.Broadcast.Application.Interfaces.GameInterfaces;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class SelectGameCommandHandler : IRequestHandler<SelectGameCommand>
{
    private readonly IGameRepository _repository;

    public SelectGameCommandHandler(IGameRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(SelectGameCommand request, CancellationToken cancellationToken)
    {
        await _repository.SelectActiveGame(request.Id);
    }
}
