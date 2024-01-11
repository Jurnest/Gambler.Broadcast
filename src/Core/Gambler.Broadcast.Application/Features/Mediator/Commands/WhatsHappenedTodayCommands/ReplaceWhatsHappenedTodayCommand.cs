using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.WhatsHappenedTodayCommands;

public class ReplaceWhatsHappenedTodayCommand : IRequest
{
    public string Description { get; set; }
}
