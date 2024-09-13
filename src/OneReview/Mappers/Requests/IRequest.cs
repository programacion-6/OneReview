using OneReview.Domain;

namespace OneReview.Mappers.Requests;

public interface IRequest<TDomain> where TDomain : IEntity
{
    TDomain ToDomain();
}

