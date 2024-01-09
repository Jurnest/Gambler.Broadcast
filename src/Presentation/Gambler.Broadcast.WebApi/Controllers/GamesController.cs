using Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;
using Gambler.Broadcast.Application.Features.Mediator.Queries.GameQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gambler.Broadcast.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    private readonly IMediator _mediator;

    public GamesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetGameList()
    {
        var values = await _mediator.Send(new GetGameQuery());
        return Ok(values);
    }

    [HttpGet("GetGameWithProducer")]
    public async Task<IActionResult> GetGameWithProducer()
    {
        var values = await _mediator.Send(new GetGameWithProducerQuery());
        return Ok(values);
    }

    [HttpGet("GetSelectedGameWithProducer")]
    public async Task<IActionResult> GetSelectedGameWithProducer()
    {
        var values = await _mediator.Send(new GetSelectedGameWithProducerQuery());
        return Ok(values);
    }

    [HttpGet("GetGameWithProducerById/{id}")]
    public async Task<IActionResult> GetGameWithProducerById(int id)
    {
        var value = await _mediator.Send(new GetGameWithProducerByIdQuery(id));
        return Ok(value);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetGameById(int id)
    {
        var value = await _mediator.Send(new GetGameByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateGame(CreateGameCommand command)
    {
        await _mediator.Send(command);
        return Ok("Game information successfully added.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveGame(int id)
    {
        await _mediator.Send(new RemoveGameCommand(id));
        return Ok("Game information successfully deleted.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateGame(UpdateGameCommand command)
    {
        await _mediator.Send(command);
        return Ok("Game information successfully updated.");
    }

    [HttpPut("SelectGame/{id}")]
    public async Task<IActionResult> SelectGame(int id)
    {
        await _mediator.Send(new SelectGameCommand(id));
        return Ok("Game information successfully updated.");
    }
}
