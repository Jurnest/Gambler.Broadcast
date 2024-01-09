using Gambler.Broadcast.Application.Interfaces.GameInterfaces;
using Gambler.Broadcast.Domain.Entities;
using Gambler.Broadcast.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Gambler.Broadcast.Persistance.Repository.GameRepository;
public class GameRepository : IGameRepository
{
    private readonly AppDbContext _appDbContext;

    public GameRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Game>> GetGamesWithProducer()
    {
        var values = await _appDbContext.Games.Include(x => x.GameProducer).ToListAsync();
        return values;
    }

    public async Task<Game> GetGameWithProducerById(int id)
    {
        var value = await _appDbContext.Games.Include(x => x.GameProducer).Where(y => y.Id == id).FirstOrDefaultAsync();
        return value;
    }

    public async Task<Game> GetSelectedGameWithProducer()
    {
        var value = await _appDbContext.Games.Include(x => x.GameProducer).Where(y => y.IsActive == true).FirstOrDefaultAsync();
        return value;
    }

    public async Task SelectActiveGame(int id)
    {
        var activeGames = await _appDbContext.Games.Where(x => x.IsActive).ToListAsync();
        foreach (var game in activeGames)
        {
            game.IsActive = false;
        }

        var gameToUpdate = await _appDbContext.Games.FirstOrDefaultAsync(x => x.Id == id);
        if (gameToUpdate != null)
        {
            gameToUpdate.IsActive = true;
        }
        await _appDbContext.SaveChangesAsync();
    }
}
