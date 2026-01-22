public class DocumentFactory
{
    public IDocument Create(string type)
    {
        if (type == "PDF") return new PDFDocument();
        if (type == "WORD") return new WordDocument();
        return null;
    }
}
