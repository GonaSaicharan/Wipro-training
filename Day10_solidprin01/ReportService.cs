public class ReportService
{
    private readonly IReportGenerator generator;
    private readonly IReportFormatter formatter;
    private readonly IReportSaver saver;

    public ReportService(IReportGenerator gen, IReportFormatter fmt, IReportSaver sav)
    {
        generator = gen;
        formatter = fmt;
        saver = sav;
    }

    public void CreateReport()
    {
        string report = generator.GenerateReport();
        string formatted = formatter.Format(report);
        saver.Save(formatted);
    }
}
