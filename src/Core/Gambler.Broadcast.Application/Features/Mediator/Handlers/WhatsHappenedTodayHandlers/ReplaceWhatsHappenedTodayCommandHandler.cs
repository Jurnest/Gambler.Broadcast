using Gambler.Broadcast.Application.Features.Mediator.Commands.WhatsHappenedTodayCommands;
using Gambler.Broadcast.Application.Interfaces.WhatsHappenedToday;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.WhatsHappenedTodayHandlers;

public class ReplaceWhatsHappenedTodayCommandHandler : IRequestHandler<ReplaceWhatsHappenedTodayCommand>
{
    private readonly IWhatsHappenedToday _repository;

    public ReplaceWhatsHappenedTodayCommandHandler(IWhatsHappenedToday repository)
    {
        _repository = repository;
    }

    public async Task Handle(ReplaceWhatsHappenedTodayCommand request, CancellationToken cancellationToken)
    {
        await _repository.ChangeWhatsHappenedToday(new WhatsHappenedToday
        {
            Description = request.Description
        });
    }
}
