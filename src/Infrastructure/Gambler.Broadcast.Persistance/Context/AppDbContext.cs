using Gambler.Broadcast.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gambler.Broadcast.Persistance.Context;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GamblerDb;Integrated Security=True;");
    }
    public DbSet<Game> Games { get; set; }
    public DbSet<GameProducer> GameProducers { get; set; }
    public DbSet<Situation> Situations { get; set; }
}
