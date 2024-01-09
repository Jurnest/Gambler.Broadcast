namespace Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;

public class GetSituationByIdQueryResult
{
    public int Id { get; set; }
    public decimal StartMoney { get; set; }
    public decimal CashIn { get; set; }
    public decimal CashOut { get; set; }
}
