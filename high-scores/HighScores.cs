using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _list;
    private const string LatestScoreTemplate = "Your latest score was {0}. ";
    private const string BestScoreTemplate = LatestScoreTemplate + "That's your personal best!";
    private const string ShortScoreTemplate = LatestScoreTemplate + "That's {1} short of your personal best!";

    public HighScores(List<int> list) => _list = list;

    public List<int> Scores() => _list;

    public int Latest() => _list.Last();

    public int PersonalBest() => _list.Max();

    public List<int> PersonalTop() => _list.OrderByDescending(v => v).Take(3).ToList();

    public string Report()
    {
        var latest = Latest();
        var personalBest = PersonalBest();

        return latest == personalBest
            ? string.Format(BestScoreTemplate, latest)
            : string.Format(ShortScoreTemplate, latest, personalBest - latest);
    }
}