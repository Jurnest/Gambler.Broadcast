using System.Security.Principal;

namespace Gambler.Broadcast.Domain.Entities;

public class Game
{
    public int Id { get; set; }
    public string GameName { get; set; }
    public int GameProducerId { get; set; }
    public decimal SelfMaxEarning { get; set; }
    public string SelfMaxMultiplier { get; set; }
    public decimal MaxMultiplier { get; set; }
    public decimal Rtp { get; set; }
    public bool IsActive { get; set; }
    public GameProducer GameProducer { get; set; }
}
