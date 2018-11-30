using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return multiples.Select(i => GetMultiplesUpToLimit(i, max))
                .SelectMany(x => x)
                .Distinct()
                .Sum();
    }

    private static IEnumerable<int> GetMultiplesUpToLimit(int multiple, int max)
    {
        if (multiple == 0)
        {
            return new[] { 0 };
        }
        else
        {
            return Enumerable.Range(1, max / multiple)
                    .Select(i => i * multiple)
                    .Where(i => i != max);
        }
    }
}
