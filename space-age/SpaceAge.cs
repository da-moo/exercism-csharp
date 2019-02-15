using System;

public class SpaceAge
{
    private const double EarthSecondsInAYear = 31_557_600;
    private const int FractionalDigits = 2;
    private readonly int _seconds;

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    private double ScaleToPlanetYears(double scale)
    {
        var num = _seconds / EarthSecondsInAYear / scale;
        return Math.Round(num, FractionalDigits);
    }

    public double OnEarth() => ScaleToPlanetYears(1);

    public double OnMercury() => ScaleToPlanetYears(0.2408467);

    public double OnVenus() => ScaleToPlanetYears(0.61519726);

    public double OnMars() => ScaleToPlanetYears(1.8808158);

    public double OnJupiter() => ScaleToPlanetYears(11.862615);

    public double OnSaturn() => ScaleToPlanetYears(29.447498);

    public double OnUranus() => ScaleToPlanetYears(84.016846);

    public double OnNeptune() => ScaleToPlanetYears(164.79132);
}