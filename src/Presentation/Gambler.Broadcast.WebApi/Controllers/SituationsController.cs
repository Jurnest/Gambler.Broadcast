using Gambler.Broadcast.Application.Features.Mediator.Commands.SituationCommands;
using Gambler.Broadcast.Application.Features.Mediator.Queries.SituationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gambler.Broadcast.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SituationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SituationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetSituationList()
    {
        var values = await _mediator.Send(new GetSituationQuery());
        return Ok(values);
    }

    [HttpGet("GetSituationLatest")]
    public async Task<IActionResult> GetSituationLatest()
    {
        var values = await _mediator.Send(new GetSituationLatestQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSituationById(int id)
    {
        var value = await _mediator.Send(new GetSituationByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSituation(CreateSituationCommand command)
    {
        await _mediator.Send(command);
        return Ok("Situation information successfully added.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveSituation(int id)
    {
        await _mediator.Send(new RemoveSituationCommand(id));
        return Ok("Situation information successfully deleted.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSituation(UpdateSituationCommand command)
    {
        await _mediator.Send(command);
        return Ok("Situation information successfully updated.");
    }
}
