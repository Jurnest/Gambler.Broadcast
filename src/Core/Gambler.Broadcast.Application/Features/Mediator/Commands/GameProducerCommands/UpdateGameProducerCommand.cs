using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;

public class UpdateGameProducerCommand : IRequest
{
    public int Id { get; set; }
    public string ProducerName { get; set; }
}
