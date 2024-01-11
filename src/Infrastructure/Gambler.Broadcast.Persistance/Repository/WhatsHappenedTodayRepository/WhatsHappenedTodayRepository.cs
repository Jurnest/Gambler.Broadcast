using Gambler.Broadcast.Application.Interfaces.WhatsHappenedToday;
using Gambler.Broadcast.Domain.Entities;
using Gambler.Broadcast.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace Gambler.Broadcast.Persistance.Repository.WhatsHappenedTodayRepository;

public class WhatsHappenedTodayRepository : IWhatsHappenedToday
{
    private readonly AppDbContext _appDbContext;

    public WhatsHappenedTodayRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task ChangeWhatsHappenedToday(WhatsHappenedToday whatsHappenedToday)
    {
        var value = await FindValue();

        if (value is null)
        {
            await CreateWhatsHappenedToday(whatsHappenedToday);
        }

        if (value is not null)
        {
            _appDbContext.WhatsHappenedTodays.Remove(value);
            await _appDbContext.SaveChangesAsync();

            await CreateWhatsHappenedToday(whatsHappenedToday);
        }
    }

    public async Task<WhatsHappenedToday> GetTodaysWhatsHappenedToday()
    {
        var value = await FindValue();
        if (value == null)
        {
            WhatsHappenedToday whatsHappenedToday = new WhatsHappenedToday()
            {
                Description = null,
                CreatedAt = DateTime.Now.Date
            };
            await CreateWhatsHappenedToday(whatsHappenedToday);

            return await FindValue();
        }
            


        return value;
    }

    private async Task CreateWhatsHappenedToday(WhatsHappenedToday whatsHappenedToday)
    {
        whatsHappenedToday.CreatedAt = DateTime.Now.Date;
        await _appDbContext.WhatsHappenedTodays.AddAsync(whatsHappenedToday);
        await _appDbContext.SaveChangesAsync();
    }

    private async Task<WhatsHappenedToday?> FindValue()
    {
        return await _appDbContext.WhatsHappenedTodays.Where(x => x.CreatedAt.Date == DateTime.Now.Date).FirstOrDefaultAsync();
    }
}
