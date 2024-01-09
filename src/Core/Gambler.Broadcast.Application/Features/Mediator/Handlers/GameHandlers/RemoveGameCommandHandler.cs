using Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class RemoveGameCommandHandler : IRequestHandler<RemoveGameCommand>
{
    private readonly IRepository<Game> _repository;

    public RemoveGameCommandHandler(IRepository<Game> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveGameCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.DeleteAsync(value);
    }
}
