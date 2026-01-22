using System;

public class WeatherDisplay : IObserver
{
    public void Update(int temp)
    {
        Console.WriteLine("Temperature: " + temp);
    }
}
