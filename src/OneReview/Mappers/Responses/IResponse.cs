using OneReview.Domain;

namespace OneReview.Mappers.Responses;

public interface IResponse<TDomain> where TDomain : IEntity
{
    static abstract IResponse<TDomain> FromDomain(TDomain domainEntity);
}
