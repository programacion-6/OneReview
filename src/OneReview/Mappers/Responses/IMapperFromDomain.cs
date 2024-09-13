namespace OneReview.Mappers.Responses;

public interface IMapperFromDomain<TDomain, TResponse>
{
    TResponse FromDomain(TDomain domain);
}