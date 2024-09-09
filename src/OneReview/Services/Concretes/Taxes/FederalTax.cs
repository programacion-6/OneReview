using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Taxes;

public class FederalTax : ITaxComponent
{
    private readonly decimal _rate;
    
    public FederalTax(decimal rate)
    {
        _rate = rate;
    }
    
    public decimal CalculateTax(decimal amount)
    {
        return amount * _rate;
    }
}
