using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;

public class SelectGameCommand : IRequest
{
    public int Id { get; set; }

    public SelectGameCommand(int id)
    {
        Id = id;
    }
}
