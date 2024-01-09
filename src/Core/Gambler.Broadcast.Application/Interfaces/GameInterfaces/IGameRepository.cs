using Gambler.Broadcast.Domain.Entities;

namespace Gambler.Broadcast.Application.Interfaces.GameInterfaces;

public interface IGameRepository
{
    Task<List<Game>> GetGamesWithProducer();
    Task<Game> GetGameWithProducerById(int id);
    Task<Game> GetSelectedGameWithProducer();
    Task SelectActiveGame(int id);
}
