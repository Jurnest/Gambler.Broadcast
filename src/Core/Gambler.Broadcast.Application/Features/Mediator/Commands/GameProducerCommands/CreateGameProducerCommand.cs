using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;

public class CreateGameProducerCommand : IRequest
{
    public string ProducerName { get; set; }
}
