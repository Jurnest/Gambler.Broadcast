using System.Diagnostics.CodeAnalysis;

namespace Gambler.Broadcast.Domain.Entities;

public class WhatsHappenedToday
{
    public int Id { get; set; }
    [AllowNull]
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}
