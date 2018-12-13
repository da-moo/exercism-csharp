using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this extension method.");
    }
}

public struct RationalNumber
{
    private readonly int _numerator, _denominator;

    public RationalNumber(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public RationalNumber Add(RationalNumber r)
    {
        var a = (_numerator * r._denominator) + (r._numerator * _denominator);
        var b = _denominator * r._denominator;
        var gcd = RationalNumber.gcd(Math.Abs(a), Math.Abs(b));
        return new RationalNumber(a / gcd, b / gcd);
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return r1.Add(r2);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        var a = (_numerator * r._denominator) - (r._numerator * _denominator);
        var b = _denominator * r._denominator;
        var gcd = RationalNumber.gcd(Math.Abs(a), Math.Abs(b));
        return new RationalNumber(a / gcd, b / gcd);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1.Sub(r2);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return r1.Mul(r2);
    }

    public RationalNumber Div(RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return r1.Div(r2);
    }

    public RationalNumber Abs()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public RationalNumber Reduce()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public RationalNumber Exprational(int power)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double Expreal(int baseNumber)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int gcd(int a, int b)
    {
        while (true)
        {
            var remainder = a % b;
            if (remainder == 0) return b;
            a = b;
            b = remainder;
        }
    }
}