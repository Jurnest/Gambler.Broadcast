using Gambler.Broadcast.Domain.Entities;

namespace Gambler.Broadcast.Application.Interfaces.SituationInterfaces;

public interface ISituationRepository
{
    Task<Situation> GetLatestSituation();
    Task<decimal> GetSituationCashIn();
}
