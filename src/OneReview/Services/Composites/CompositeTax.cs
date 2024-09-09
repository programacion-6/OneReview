using OneReview.Services.Interfaces;

namespace OneReview.Services.Composites;

public class CompositeTax : ITaxComponent
{
    private readonly List<ITaxComponent> _taxComponents;

    public CompositeTax() 
    {
        _taxComponents = new List<ITaxComponent>();
    }

    public void Add(ITaxComponent taxComponent)
    {
        _taxComponents.Add(taxComponent);
    }

    public void Remove(ITaxComponent taxComponent)
    {
        _taxComponents.Remove(taxComponent);
    }

    public decimal CalculateTax(decimal amount)
    {
        decimal totalTax = 0;

        foreach (var taxComponent in _taxComponents)
        {
            totalTax += taxComponent.CalculateTax(amount);
        }
        
        return totalTax;
    }
}
