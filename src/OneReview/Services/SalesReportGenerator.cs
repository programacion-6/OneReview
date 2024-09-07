namespace OneReview.Services;

public class SalesReportGenerator : AbstractReportGenerator
{
    protected override void LoadData()
    {
        Console.WriteLine("Loading sales data...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Processing sales data...");
    }

    protected override void FormatReport()
    {
        Console.WriteLine("Formatting sales report...");
    }

    protected override void SaveReport()
    {
        Console.WriteLine("Saving sales report...");
    }
}