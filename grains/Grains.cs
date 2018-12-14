using System;
using System.Numerics;

public static class Grains
{
    private const int NumSquares = 64;

    public static ulong Square(int n) => n <= 0 || n > NumSquares
            ? throw new ArgumentOutOfRangeException(nameof(n), "Must be between 1 and 64 (inclusive)")
            : (ulong)Math.Pow(2, n - 1);

    public static ulong Total() => (ulong)(BigInteger.Pow(2, NumSquares) - 1);
}