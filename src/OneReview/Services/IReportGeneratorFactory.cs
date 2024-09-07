namespace OneReview.Services;

public interface IReportGeneratorFactory
{
    AbstractReportGenerator CreateReportGenerator();
}