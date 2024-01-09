using Gambler.Broadcast.Application.Features.Mediator.Queries.GameProducerQueries;
using Gambler.Broadcast.Application.Features.Mediator.Results.GameProducerResults;
using Gambler.Broadcast.Application.Interfaces;
using Gambler.Broadcast.Domain.Entities;
using MediatR;

namespace Gambler.Broadcast.Application.Features.Mediator.Handlers.GameProducerHandlers;

public class GetGameProducerByIdQueryHandler : IRequestHandler<GetGameProducerByIdQuery, GetGameProcuderByIdQueryResult>
{
    private readonly IRepository<GameProducer> _repository;

    public GetGameProducerByIdQueryHandler(IRepository<GameProducer> repository)
    {
        _repository = repository;
    }

    public async Task<GetGameProcuderByIdQueryResult> Handle(GetGameProducerByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetGameProcuderByIdQueryResult
        {
            Id = value.Id,
            ProducerName = value.ProducerName
        };
    }
}
