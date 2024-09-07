using OneReview.Services.Interfaces;

namespace OneReview.Services.Concretes.Taxes;

public class StateTax : ITaxComponent
{
    private readonly decimal _rate;
    
    public StateTax(decimal rate)
    {
        _rate = rate;
    }
    
    public decimal CalculateTax(decimal amount)
    {
        return amount * _rate;
    }
}
