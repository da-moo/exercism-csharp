using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    private static readonly Regex AllowedNucleotidesPattern = new Regex("[^AGCT]", RegexOptions.Compiled);

    public static IDictionary<char, int> Count(string sequence)
    {
        if (AllowedNucleotidesPattern.IsMatch(sequence))
            throw new ArgumentException("Invalid nucleotide in string");
        var dictCount = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach (char nucleotide in sequence) dictCount[nucleotide]++;
        return dictCount;
    }
}