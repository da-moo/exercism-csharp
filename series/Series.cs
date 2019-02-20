using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length)
        {
            throw new ArgumentException(
                $"{nameof(sliceLength)} cannot be larger than the length of ${nameof(numbers)}");
        }

        if (string.IsNullOrEmpty(numbers))
        {
            throw new ArgumentException($"{nameof(numbers)} cannot be empty or null");
        }

        if (sliceLength <= 0)
        {
            throw new ArgumentException($"{nameof(sliceLength)} cannot be less than 1");
        }

        string[] slices = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices[i] = numbers.Substring(i, sliceLength);
        }

        return slices;
    }
}