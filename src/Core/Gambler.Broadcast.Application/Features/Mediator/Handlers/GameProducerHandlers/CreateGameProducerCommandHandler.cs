using Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameProducerHandlers;

public class CreateGameProducerCommandHandler : IRequestHandler<CreateGameProducerCommand>
{
    private readonly IRepository<GameProducer> _repository;

    public CreateGameProducerCommandHandler(IRepository<GameProducer> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateGameProducerCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new GameProducer
        {
            ProducerName = request.ProducerName
        });
    }
}