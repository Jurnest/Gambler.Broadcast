using Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameProducerHandlers;

public class RemoveGameProducerCommandHandler : IRequestHandler<RemoveGameProducerCommand>
{
    private readonly IRepository<GameProducer> _repository;

    public RemoveGameProducerCommandHandler(IRepository<GameProducer> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveGameProducerCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.DeleteAsync(value);
    }
}
