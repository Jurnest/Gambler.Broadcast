using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;

public class RemoveGameProducerCommand : IRequest
{
    public int Id { get; set; }

    public RemoveGameProducerCommand(int id)
    {
        Id = id;
    }
}
