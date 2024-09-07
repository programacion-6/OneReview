namespace OneReview.Services;

public class ProductValidatorWithLogging : ValidatorDecorator<Product>
{
    public ProductValidatorWithLogging(IValidator<Product> wrappee)
    : base(wrappee)
    {
    }

    public override bool Validate(Product product)
    {
        Logger.Instance.Log($"Validating product: {product.Name}");

        var isValid = base.Validate(product);

        if (isValid)
        {
            Logger.Instance.Log($"Product '{product.Name}' is valid.");
        }
        else
        {
            Logger.Instance.Log($"Product '{product.Name}' is invalid.");
        }

        return isValid;
    }
}
