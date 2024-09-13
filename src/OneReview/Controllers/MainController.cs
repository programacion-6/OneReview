namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Domain;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;

[ApiController]
[Route("api/v1/[controller]")]
public abstract class MainController<TRequest, TResponse, TDomain> : ControllerBase
    where TDomain : IEntity
    where TRequest : IRequest<TDomain>
    where TResponse : IResponse<TDomain>
{
    protected abstract Task CreateAsync(TDomain domainEntity);
    protected abstract Task<TDomain> GetAsync(Guid id);

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TRequest request)
    {
        var domainEntity = request.ToDomain();
        await CreateAsync(domainEntity);
        var response = TResponse.FromDomain(domainEntity);

        return CreatedAtAction(
            actionName: nameof(Get),
            routeValues: new { id = domainEntity.Id },
            value: response
        );
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var domainEntity = await GetAsync(id);
        return domainEntity == null
            ? Problem(statusCode: StatusCodes.Status404NotFound, detail: $"Entity not found (ID {id})")
            : Ok(TResponse.FromDomain(domainEntity));
    }
}
