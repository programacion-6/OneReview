namespace OneReview.Services;

public class ReportManager
{
    private static ReportManager _instance;
    private static readonly object _lock = new object();

    private ReportManager()
    {
    }

    public static ReportManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ReportManager();
                }
                return _instance;
            }
        }
    }

    public void GenerateReport(AbstractReportGenerator reportGenerator)
    {
        if (reportGenerator == null)
        {
            throw new ArgumentNullException(nameof(reportGenerator), "Report generator cannot be null.");
        }

        reportGenerator.GenerateReport();
    }
}