using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> TranslationDictionary = new Dictionary<string, string>
    {
        {"AUG", "Methionine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
        {"UAA", "STOP"},
        {"UAG", "STOP"},
        {"UGA", "STOP"}
    };

    private static readonly Regex ParserRegex = new Regex(@".{3}", RegexOptions.Compiled);

    public static string[] Proteins(string strand)
    {
        var proteins = new List<string>();
        foreach (var codon in ParserRegex.Matches(strand))
        {
            var protein = TranslationDictionary[codon.ToString()];
            if (protein == "STOP")
                break;
            if (TranslationDictionary.ContainsValue(protein))
                proteins.Add(protein);
        }

        return proteins.ToArray();
    }
}