namespace OneReview.Services;

using OneReview.Models;

public interface IService<TBase, TResponse>
{
    Task<ServiceResult<TResponse>> CreateAsync(TBase entity);

    Task<ServiceResult<TResponse>> GetByIdAsync(Guid id);
}
