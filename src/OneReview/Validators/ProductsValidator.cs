namespace OneReview.Validators;

using FluentValidation;
using OneReview.Domain;

public class ProductsValidator : AbstractValidator<Product>
{
    public ProductsValidator()
    {
        RuleFor((product) => product.Name)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor((product) => product.Description)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor((product) => product.Category)
            .NotEmpty()
            .MaximumLength(10);

        RuleFor((product) => product.SubCategory)
            .NotEmpty()
            .MaximumLength(10);
    }
}
