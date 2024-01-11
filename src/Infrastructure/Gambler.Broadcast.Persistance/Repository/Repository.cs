using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Gambler.Broadcast.Persistance.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _appDbContext;

    public Repository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _appDbContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _appDbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task CreateAsync(TEntity entity)
    {
        await _appDbContext.Set<TEntity>().AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
    }
    public async Task UpdateAsync(TEntity entity)
    {
        await _appDbContext.Set<TEntity>().AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _appDbContext.Set<TEntity>().Remove(entity);
        await _appDbContext.SaveChangesAsync();
    }
}
