using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Application.Interfaces.GameInterfaces;
using Gambler.Broadcast.Application.Interfaces.SituationInterfaces;
using Gambler.Broadcast.Application.Services;
using Gambler.Broadcast.Persistance.Context;
using Gambler.Broadcast.Persistance.Repository;
using Gambler.Broadcast.Persistance.Repository.GameRepository;
using Gambler.Broadcast.Persistance.Repository.NewFolder;
using Gambler.Broadcast.WebApi.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IGameRepository), typeof(GameRepository));
builder.Services.AddScoped(typeof(ISituationRepository), typeof(SituationRepository));

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed((host) => true)
            .AllowCredentials());
});

builder.Services.AddSignalR();
builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SituationsHub>("/situationhub");

app.Run();
