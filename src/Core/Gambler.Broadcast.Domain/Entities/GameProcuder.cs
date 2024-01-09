namespace Gambler.Broadcast.Domain.Entities;

public class GameProducer
{
    public int Id { get; set; }
    public string ProducerName { get; set; }
    public List<Game> Games { get; set; }
}
