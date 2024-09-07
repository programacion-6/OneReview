namespace OneReview.Services;

public class InventoryReportGeneratorFactory : IReportGeneratorFactory
{
    public AbstractReportGenerator CreateReportGenerator()
    {
        return new InventoryReportGenerator();
    }
}