using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;

public class RemoveSituationCommand : IRequest
{
    public RemoveSituationCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
