namespace OneReview.Services;

public class ValidatorDecorator<T> : IValidator<T>
{
    private readonly IValidator<T> _wrappee;

    public ValidatorDecorator(IValidator<T> wrappee)
    {
        _wrappee = wrappee;
    }

    public virtual bool Validate(T entity)
    {
        return _wrappee.Validate(entity);
    }
}
