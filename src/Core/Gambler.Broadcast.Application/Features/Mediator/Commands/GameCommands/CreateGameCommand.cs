﻿using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Commands.GameCommands;

public class CreateGameCommand : IRequest
{
    public string GameName { get; set; }
    public int GameProducerId { get; set; }
    public decimal SelfMaxEarning { get; set; }
    public string SelfMaxMultiplier { get; set; }
    public decimal MaxMultiplier { get; set; }
    public decimal Rtp { get; set; }
    public bool IsActive { get; set; }
}
