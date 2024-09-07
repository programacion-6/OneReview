namespace OneReview.Services;

public class SalesReportGeneratorFactory : IReportGeneratorFactory
{
    public AbstractReportGenerator CreateReportGenerator()
    {
        return new SalesReportGenerator();
    }
}