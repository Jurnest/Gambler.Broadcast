using Gambler.Broadcast.Persistance.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class PrepDb
{
    public static void ApplyMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var dataContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        dataContext.Database.Migrate();
    }
}
