using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    private static readonly Regex PhoneNumberSanitizerRegex = new Regex(@"^\+*1|\D");
    private static readonly Regex InvalidNumberRegex = new Regex(@"^(0|1)|.{3}(0|1).{6}");
    public static string Clean(string phoneNumber)
    {
        var cleanedNumber = PhoneNumberSanitizerRegex.Replace(phoneNumber, "");
        if (InvalidNumberRegex.IsMatch(cleanedNumber) || cleanedNumber.Length != 10)
            throw new ArgumentException();
        return cleanedNumber;
    }
}