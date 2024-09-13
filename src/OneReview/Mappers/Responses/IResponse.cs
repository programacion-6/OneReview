using OneReview.Domain.Interface;

namespace OneReview.Mappers.Responses;

public interface IResponse<TEntity> where TEntity : IEntity
{
    static abstract TEntity FromDomain(TEntity entity);
}