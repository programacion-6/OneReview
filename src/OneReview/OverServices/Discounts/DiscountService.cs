namespace OneReview.OverServices.Discounts;

public class DiscountService : IDiscountService
{
    private readonly IServiceProvider _serviceProvider;

    public DiscountService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public decimal ApplyDiscount(decimal amount, DiscountType discountType)
    {
        var strategy = discountType switch
        {
            DiscountType.None => (IDiscountStrategy)_serviceProvider.GetService<NoDiscountStrategy>(),
            DiscountType.Percentage => (IDiscountStrategy)_serviceProvider.GetService<PercentageDiscountStrategy>(),
            DiscountType.Flat => (IDiscountStrategy)_serviceProvider.GetService<FlatRateDiscountStrategy>(),
            _ => throw new NotSupportedException("Discount type not supported")
        };

        if (strategy == null)
        {
            throw new InvalidOperationException("Discount strategy could not be resolved.");
        }

        return strategy.ApplyDiscount(amount);
    }
}
