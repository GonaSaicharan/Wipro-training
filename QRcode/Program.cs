using QRCoder;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of QRCodeGenerator
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        
        // Generate QR code data from a sample text
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("nothing", QRCodeGenerator.ECCLevel.Q);
        
        // Create a QR code from the generated data
        QRCode qrCode = new QRCode(qrCodeData);
        
        // Render the QR code as a bitmap image
        using (var qrCodeImage = qrCode.GetGraphic(20))
        {
            // Save the QR code image to a file
            qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine("QR code generated and saved as qrcode.png");
        }
    }
}