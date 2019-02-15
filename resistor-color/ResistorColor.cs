﻿using System;
using System.Collections.Generic;

public static class ResistorColor
{
    private static readonly List<string> ColorsList = new List<string>
        {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static int ColorCode(string color)
    {
        var code = ColorsList.IndexOf(color);

        if (code == -1) throw new ArgumentException($"Invalid color: {color}");

        return code;
    }

    public static string[] Colors()
    {
        return ColorsList.ToArray();
    }
}