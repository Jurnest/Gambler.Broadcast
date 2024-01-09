namespace Gambler.Broadcast.Application.Features.Mediator.Results.GameResults;

public class GetGameWithProducerQueryResult
{
    public int Id { get; set; }
    public string GameName { get; set; }
    public int GameProducerId { get; set; }
    public decimal SelfMaxEarning { get; set; }
    public string SelfMaxMultiplier { get; set; }
    public decimal MaxMultiplier { get; set; }
    public decimal Rtp { get; set; }
    public bool IsActive { get; set; }
}
