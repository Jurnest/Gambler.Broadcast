namespace Gambler.Broadcast.Domain.Entities;

public class Situation
{
    public int Id { get; set; }
    public decimal StartMoney { get; set; }
    public decimal CashIn { get; set; }
    public decimal CashOut { get; set; }
    public DateTime CreatedAt { get; set; }
}
