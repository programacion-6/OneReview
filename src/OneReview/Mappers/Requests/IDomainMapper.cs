namespace OneReview.Mappers.Requests;

public interface IDomainMapper<T>
{
    T ToDomain();
}