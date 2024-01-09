using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;

public class RemoveGameCommand : IRequest
{
    public int Id { get; set; }

    public RemoveGameCommand(int id)
    {
        Id = id;
    }
}