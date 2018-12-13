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
        return new RationalNumber(a, b).Reduce();
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return r1.Add(r2);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        var a = (_numerator * r._denominator) - (r._numerator * _denominator);
        var b = _denominator * r._denominator;
        return new RationalNumber(a, b).Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1.Sub(r2);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        var a = _numerator * r._numerator;
        var b = _denominator * r._denominator;
        return new RationalNumber(a, b).Reduce();
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return r1.Mul(r2);
    }

    public RationalNumber Div(RationalNumber r)
    {
        var a = _numerator * r._denominator;
        var b = r._numerator * _denominator;
        if (b == 0) throw new ArithmeticException("Division resulted in a denominator of zero");
        return new RationalNumber(a, b).Reduce();
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
        var a = Math.Abs(_numerator);
        var b = Math.Abs(_denominator);
        var gcd = RationalNumber.gcd(a, b);
        
        // If the rational number is negative, ensure the numerator is negative
        a = _numerator * _denominator < 0 ? a * -1 : a;
        return new RationalNumber(a / gcd, b / gcd);
    }

    public RationalNumber Exprational(int power)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double Expreal(int baseNumber)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    private static int gcd(int a, int b)
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