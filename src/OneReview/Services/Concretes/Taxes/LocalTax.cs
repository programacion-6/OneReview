using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Taxes;

public class LocalTax : ITaxComponent
{
    private readonly decimal _rate;
    
    public LocalTax(decimal rate)
    {
        _rate = rate;
    }
    
    public decimal CalculateTax(decimal amount)
    {
        return amount * _rate;
    }
}
