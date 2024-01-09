using Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameProducerHandlers;

public class UpdateGameProducerCommandHandler : IRequestHandler<UpdateGameProducerCommand>
{
    private readonly IRepository<GameProducer> _repository;

    public UpdateGameProducerCommandHandler(IRepository<GameProducer> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateGameProducerCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        values.ProducerName = request.ProducerName;
        await _repository.UpdateAsync(values);
    }
}
