using System;

public static class ResistorColor
{
    private static readonly string[] ColorsArray =
        {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static int ColorCode(string color) => Array.IndexOf(ColorsArray, color);

    public static string[] Colors() => ColorsArray;
}