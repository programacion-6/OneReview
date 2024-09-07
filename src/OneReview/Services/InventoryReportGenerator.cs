namespace OneReview.Services;

public class InventoryReportGenerator : AbstractReportGenerator
{
    protected override void LoadData()
    {
        Console.WriteLine("Loading inventory data...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Processing inventory data...");
    }

    protected override void FormatReport()
    {
        Console.WriteLine("Formatting inventory report...");
    }

    protected override void SaveReport()
    {
        Console.WriteLine("Saving inventory report...");
    }
}
