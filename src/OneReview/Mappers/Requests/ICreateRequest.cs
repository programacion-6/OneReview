using OneReview.Domain.Interface;

namespace OneReview.Mappers.Requests;

public interface ICreateRequest<TEntity> where TEntity : IEntity
{
    TEntity ToDomain();
}