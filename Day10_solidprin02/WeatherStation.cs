using System.Collections.Generic;

public class WeatherStation
{
    private List<IObserver> observers = new();

    public void Register(IObserver o) => observers.Add(o);
    public void Unregister(IObserver o) => observers.Remove(o);

    public void SetTemperature(int temp)
    {
        foreach (var o in observers)
            o.Update(temp);
    }
}
