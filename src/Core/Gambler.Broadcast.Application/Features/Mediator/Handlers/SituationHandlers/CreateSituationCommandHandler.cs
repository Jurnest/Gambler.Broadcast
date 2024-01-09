using Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.SituationHandlers;

public class CreateSituationCommandHandler : IRequestHandler<CreateSituationCommand>
{
    private readonly IRepository<Situation> _repository;

    public CreateSituationCommandHandler(IRepository<Situation> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateSituationCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Situation
        {
            CashIn = request.CashIn,
            CashOut = request.CashOut,
            StartMoney = request.StartMoney           
        });
    }
}
