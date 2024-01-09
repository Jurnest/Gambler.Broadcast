using Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.SituationHandlers;

public class RemoveSituationCommandHandler : IRequestHandler<RemoveSituationCommand>
{
    private readonly IRepository<Situation> _repository;

    public RemoveSituationCommandHandler(IRepository<Situation> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveSituationCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.DeleteAsync(value);
    }
}
