using System;
using System.Collections.Generic;

public class UniversityRegistry
{
    private List<UniversityMember> members = new List<UniversityMember>();

    public void AddMember(UniversityMember m)
    {
        members.Add(m);
    }

    public void ExecuteAllDuties()
    {
        foreach (var member in members)
        {
            try
            {
                member.PerformDuties();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[BLOCKED] {ex.Message}");
            }
        }
    }

    public string GetMemberStatistics()
    {
        int total = 0;
        string result = "=== Statistics ===\n";
        foreach (var member in members)
        {
            result += $"{member.Name} ({member.GetType().Name}): {member.ActionCount} actions\n";
            total += member.ActionCount;
        }
        result += $"Total across all members: {total} actions";
        return result;
    }
}