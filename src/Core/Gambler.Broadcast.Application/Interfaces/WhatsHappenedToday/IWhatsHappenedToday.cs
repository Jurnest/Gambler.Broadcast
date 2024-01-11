using Gambler.Broadcast.Domain.Entities;

namespace Gambler.Broadcast.Application.Interfaces.WhatsHappenedToday;

public interface IWhatsHappenedToday
{
    Task ChangeWhatsHappenedToday(Domain.Entities.WhatsHappenedToday whatsHappenedToday);
    Task<Domain.Entities.WhatsHappenedToday> GetTodaysWhatsHappenedToday();
}
