using Gambler.Broadcast.Application.Features.Mediator.Commands.GameProducerCommands;
using Gambler.Broadcast.Application.Features.Mediator.Queries.GameProducerQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gambler.Broadcast.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GameProcudersController : ControllerBase
{
    private readonly IMediator _mediator;

    public GameProcudersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetGameProducerList()
    {
        var values = await _mediator.Send(new GetGameProducerQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetGameProducerById(int id)
    {
        var value = await _mediator.Send(new GetGameProducerByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateGameProducer(CreateGameProducerCommand command)
    {
        await _mediator.Send(command);
        return Ok("GameProducer information successfully added.");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveGameProducer(int id)
    {
        await _mediator.Send(new RemoveGameProducerCommand(id));
        return Ok("GameProducer information successfully deleted.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateGameProducer(UpdateGameProducerCommand command)
    {
        await _mediator.Send(command);
        return Ok("GameProducer information successfully updated.");
    }
}
