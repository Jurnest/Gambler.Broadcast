using Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.SituationHandlers;

public class UpdateSituationCommandHandler : IRequestHandler<UpdateSituationCommand>
{
    private readonly IRepository<Situation> _repository;

    public UpdateSituationCommandHandler(IRepository<Situation> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateSituationCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        values.CashIn = request.CashIn;
        values.CashOut = request.CashOut;
        values.StartMoney = request.StartMoney;
        await _repository.UpdateAsync(values);
    }
}
