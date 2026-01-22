using System.IO;

public class ReportSaver : IReportSaver
{
    public void Save(string content)
    {
        File.WriteAllText("report.txt", content);
    }
}
