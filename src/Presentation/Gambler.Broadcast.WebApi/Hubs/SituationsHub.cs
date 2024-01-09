using Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using Gambler.Broadcast.Application.Interfaces.SituationInterfaces;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Gambler.Broadcast.WebApi.Hubs;

public class SituationsHub : Hub
{
    private readonly IMediator _mediator;
    private readonly ISituationRepository _repository;

    public SituationsHub(IMediator mediator, ISituationRepository repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    public async Task SendSituation()
    {
        var value = _mediator.Send(new GetSituationLatestQuery());
        await Clients.All.SendAsync("ReciveSituationLatest", value);

        var value2 = _repository.GetSituationCashIn;
        await Clients.All.SendAsync("ReciveGetSituationCashIn", value2);
    }
}
