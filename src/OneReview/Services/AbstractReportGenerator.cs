namespace OneReview.Services;

public abstract class AbstractReportGenerator
{
    public void GenerateReport()
    {
        LoadData();
        ProcessData();
        FormatReport();
        SaveReport();
    }

    protected abstract void LoadData();
    protected abstract void ProcessData();
    protected abstract void FormatReport();
    protected abstract void SaveReport();
}