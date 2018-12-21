using System;
using System.Collections.Generic;

public enum Child
{
    Alice,
    Bob,
    Charlie,
    David,
    Eve,
    Fred,
    Ginny,
    Harriet,
    Ileana,
    Joseph,
    Kincaid,
    Larry
}

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private static readonly Dictionary<char, Plant> PlantCharToEnumDictionary = new Dictionary<char, Plant>
    {
        {'V', Plant.Violets},
        {'R', Plant.Radishes},
        {'C', Plant.Clover},
        {'G', Plant.Grass}
    };

    private readonly Dictionary<Child, List<Plant>> gardenDictionary = new Dictionary<Child, List<Plant>>();

    public KindergartenGarden(string diagram)
    {
        foreach (Child child in Enum.GetValues(typeof(Child))) gardenDictionary.Add(child, new List<Plant>());

        foreach (var line in diagram.Split("\n"))
        {
            var counter = 0;
            foreach (var character in line)
            {
                var currentChild = (Child) (counter / 2);
                gardenDictionary[currentChild].Add(PlantCharToEnumDictionary[character]);
                counter++;
            }
        }
    }

    public IEnumerable<Plant> Plants(string student)
    {
        Enum.TryParse(student, out Child childAsEnum);
        return gardenDictionary[childAsEnum];
    }
}