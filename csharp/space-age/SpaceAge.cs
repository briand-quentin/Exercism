using System;

public class SpaceAge
{
    private double _secondEarthYears = 31557600.00;
    private double _daysEarthYears = 365.25;
    private int _seconds;

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        return _seconds / _secondEarthYears;
    }

    public double OnMercury()
    {
        return Math.Round(OnEarth() / 0.2408467, 2);
    }

    public double OnVenus()
    {
        return Math.Round(OnEarth() / 0.61519726, 2);
    }

    public double OnMars()
    {
        return Math.Round(OnEarth() / 1.8808158, 2);
    }

    public double OnJupiter()
    {
        return Math.Round(OnEarth() / 11.862615, 2);
    }

    public double OnSaturn()
    {
        return Math.Round(OnEarth() / 29.447498, 2);
    }

    public double OnUranus()
    {
        return Math.Round(OnEarth() / 84.016846, 2);
    }

    public double OnNeptune()
    {
        return Math.Round(OnEarth() / 164.79132, 2);
    }
}