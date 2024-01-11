using Gambler.Broadcast.Application.Interfaces.SituationInterfaces;
using Gambler.Broadcast.Domain.Entities;
using Gambler.Broadcast.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Gambler.Broadcast.Persistance.Repository.SituationRepository;

public class SituationRepository : ISituationRepository
{
    private readonly AppDbContext _context;

    public SituationRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Situation> GetLatestSituation()
    {
        var value = await _context.Situations.OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync();
        return value;
    }

    public async Task<decimal> GetSituationCashIn()
    {
        var value = await _context.Situations.OrderByDescending(x => x.CreatedAt).Select(y => y.CashIn).FirstOrDefaultAsync();

        return value;
    }
}
