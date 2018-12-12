using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<string, int> _roster = new Dictionary<string, int>();

    public void Add(string student, int grade)
    {
        _roster.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return _roster
            .OrderBy(x => x.Value)
            .ThenBy(x => x.Key)
            .Select(x => x.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _roster
            .Where(x => x.Value == grade)
            .OrderBy(x => x.Key)
            .Select(x => x.Key);
    }
}