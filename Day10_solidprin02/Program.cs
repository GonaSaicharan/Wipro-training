using System;

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Application Started");

        var factory = new DocumentFactory();
        var doc = factory.Create("PDF");
        Console.WriteLine(doc.GetTypeName());

        var station = new WeatherStation();
        var display = new WeatherDisplay();
        station.Register(display);
        station.SetTemperature(30);
    }
}
