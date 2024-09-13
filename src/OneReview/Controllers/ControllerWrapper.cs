namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using OneReview.Mappers.Requests;
using OneReview.Mappers.Responses;
using OneReview.Services;

[ApiController]
[Route("api/v1/[controller]")]
public abstract class ControllerWrapper<TEntity, TEntityResponse, TEntityRequest> : ControllerBase
    where TEntity : EntityBase
    where TEntityRequest : IDomainMapper<TEntity>
{
    private readonly IMapperFromDomain<TEntity, TEntityResponse> _mapperFromDomain;

    protected ControllerWrapper(IMapperFromDomain<TEntity, TEntityResponse> mapperFromDomain)
    {
        _mapperFromDomain = mapperFromDomain;
    }

    protected abstract Task<TEntity> CreateEntity(TEntityRequest request);
    protected abstract Task<TEntity> GetEntity(Guid id);

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TEntityRequest request)
    {
        var entity = await CreateEntity(request);
        var response = _mapperFromDomain.FromDomain(entity);

        return CreatedAtAction(nameof(Get), new { id = entity.Id }, response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var entity = await GetEntity(id);

        if (entity is not null)
        {
            var response = _mapperFromDomain.FromDomain(entity);
            return Ok(response);
        }

        return NotFound($"Entity not found");
    }
}
