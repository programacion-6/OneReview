
using Microsoft.AspNetCore.Mvc;

using OneReview.Domain.Interface;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;

namespace OneReview.Controllers;

public abstract class MainController<TCreateRequest, TResponse, TEntity> : ControllerBase
    where TEntity : class, IEntity
    where TCreateRequest : ICreateRequest<TEntity>
    where TResponse : IResponse<TEntity>
{
    protected abstract Task<TEntity> CreateEntityAsync(TCreateRequest request);
    protected abstract Task<TEntity> GetEntityAsync(Guid id);

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TCreateRequest request)
    {
        var entity = await CreateEntityAsync(request);
        var response = TResponse.FromDomain(entity);
        return CreatedAtAction(nameof(Get), new { id = entity.Id }, response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var entity = await GetEntityAsync(id);

        if (entity == null)
        {
            return NotFound($"Entity not found (id: {id})");
        }

        var response = TResponse.FromDomain(entity);
        return Ok(response);
    }
}
