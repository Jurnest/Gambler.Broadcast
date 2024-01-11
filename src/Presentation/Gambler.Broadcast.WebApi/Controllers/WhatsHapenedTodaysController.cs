using Gambler.Broadcast.Application.Features.Mediator.Commands.WhatsHappenedTodayCommands;
using Gambler.Broadcast.Application.Features.Mediator.Queries.GameProducerQueries;
using Gambler.Broadcast.Application.Features.Mediator.Queries.WhatsHappenedTodayQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gambler.Broadcast.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WhatsHapenedTodaysController : ControllerBase
{
    private readonly IMediator _mediator;

    public WhatsHapenedTodaysController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetWhatHapenedToday()
    {
        var values = await _mediator.Send(new GetWhatsHappenedTodayLatestQuery());
        return Ok(values);
    }

    [HttpPut]
    public async Task<IActionResult> ReplaceWhatHapenedToday(ReplaceWhatsHappenedTodayCommand command)
    {
        await _mediator.Send(command);
        return Ok("The descriptions is succesfully replaced.");
    }
}
