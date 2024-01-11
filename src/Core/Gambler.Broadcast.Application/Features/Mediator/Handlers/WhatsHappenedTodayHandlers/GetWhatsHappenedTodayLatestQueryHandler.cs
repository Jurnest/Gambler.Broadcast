using Gambler.Broadcast.Application.Features.Mediator.Queries.WhatsHappenedTodayQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.SituationResults;
using Gambler.Broadcast.Application.Features.Mediator.Results.WhatsHappenedToday;
using Gambler.Broadcast.Application.Interfaces.WhatsHappenedToday;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.WhatsHappenedTodayHandlers;

public class GetWhatsHappenedTodayLatestQueryHandler : IRequestHandler<GetWhatsHappenedTodayLatestQuery, GetWhatsHappenedTodayLatestQueryResult>
{
    private readonly IWhatsHappenedToday _repository;

    public GetWhatsHappenedTodayLatestQueryHandler(IWhatsHappenedToday repository)
    {
        _repository = repository;
    }

    public async Task<GetWhatsHappenedTodayLatestQueryResult> Handle(GetWhatsHappenedTodayLatestQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetTodaysWhatsHappenedToday();
        if(value == null)
        {
            return null;
        }

        return new GetWhatsHappenedTodayLatestQueryResult
        {
            Description = value.Description
        };
    }
}
