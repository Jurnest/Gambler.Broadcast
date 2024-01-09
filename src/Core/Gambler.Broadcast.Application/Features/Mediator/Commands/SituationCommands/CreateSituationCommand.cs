using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;

public class CreateSituationCommand : IRequest
{
    public decimal StartMoney { get; set; }
    public decimal CashIn { get; set; }
    public decimal CashOut { get; set; }
}
