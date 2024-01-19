// ReSharper disable InvalidXmlDocComment

using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

/**
 * In a project, you have a list of required skills req_skills, and a list of people.
 * The ith person people[i] contains a list of skills that the person has.
 *
 * Consider a sufficient team: a set of people such that for every required skill in req_skills,
 * there is at least one person in the team who has that skill.
 * We can represent these teams by the index of each person.
 *
 * For example, team = [0, 1, 3] represents the people with skills people[0], people[1], and people[3].
 * Return any sufficient team of the smallest possible size, represented by the index of each person.
 * You may return the answer in any order.
 *
 * It is guaranteed an answer exists.
 *
 * Constraints:

    1 <= req_skills.length <= 16
    1 <= req_skills[i].length <= 16
    req_skills[i] consists of lowercase English letters.
    All the strings of req_skills are unique.
    1 <= people.length <= 60
    0 <= people[i].length <= 16
    1 <= people[i][j].length <= 16
    people[i][j] consists of lowercase English letters.
    All the strings of people[i] are unique.
    Every skill in people[i] is a skill in req_skills.

 */

public class CalculateTeamTest
{
    private readonly CalculateTeam _sut;

    public CalculateTeamTest()
    {
        _sut = new CalculateTeam();
    }

    [Fact]
    public void SmallestSufficientTeam_ShouldCalculate_TestCase1()
    {
        var requiredSkills = new[] { "java", "nodejs", "reactjs" };
        var people = new List<IList<string>>()
        {
            new List<string> { "java" },
            new List<string> { "nodejs" },
            new List<string> { "nodejs", "reactjs" }
        };
        var expected = new[] { 0, 2 };

        _sut.SmallestSufficientTeam(requiredSkills, people).ShouldBe(expected);
    }

    [Fact]
    public void SmallestSufficientTeam_ShouldCalculate_TestCase2()
    {
        var requiredSkills = new [] { "algorithms", "math", "java", "reactjs", "csharp", "aws" };
        var people = new List<IList<string>>()
        {
            new List<string> { "algorithms", "math", "java" },
            new List<string> { "algorithms", "math", "reactjs" },
            new List<string> { "java", "csharp", "aws" },
            new List<string> { "reactjs", "csharp" },
            new List<string> { "csharp", "math" },
            new List<string> { "aws", "java" }
        };
        var expected = new[] { 1, 2 };

        _sut.SmallestSufficientTeam(requiredSkills, people).ShouldBe(expected);
    }
}
