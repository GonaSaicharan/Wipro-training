using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ReportTests
{
    [TestMethod]
    public void ReportService_Creates_Report()
    {
        var gen = new ReportGenerator();
        var fmt = new PDFFormatter();
        var sav = new ReportSaver();
        var service = new ReportService(gen, fmt, sav);

        service.CreateReport();

        Assert.IsTrue(System.IO.File.Exists("report.txt"));
    }
}
