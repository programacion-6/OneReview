namespace OneReview.Services;

public interface IValidator<T>
{
    public bool Validate(T entity);
}