public class PDFFormatter : IReportFormatter
{
    public string Format(string content)
    {
        return "PDF: " + content;
    }
}
