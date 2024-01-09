using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;

public class UpdateSituationCommand : IRequest
{

    public int Id { get; set; }
    public decimal StartMoney { get; set; }
    public decimal CashIn { get; set; }
    public decimal CashOut { get; set; }
}
