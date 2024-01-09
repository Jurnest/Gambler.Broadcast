using Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameHandlers;

public class UpdateGameCommandHandler : IRequestHandler<UpdateGameCommand>
{
    private readonly IRepository<Game> _repository;

    public UpdateGameCommandHandler(IRepository<Game> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateGameCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        values.Rtp = request.Rtp;
        values.SelfMaxMultiplier = request.SelfMaxMultiplier;
        values.MaxMultiplier = request.MaxMultiplier;
        values.GameProducerId = request.GameProducerId;
        values.IsActive = request.IsActive;
        values.GameName = request.GameName;
        values.SelfMaxEarning = request.SelfMaxEarning;
        await _repository.UpdateAsync(values);
    }
}
