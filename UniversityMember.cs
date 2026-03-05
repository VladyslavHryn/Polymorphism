using System;
using System.Collections.Generic;

public class UniversityMember
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Name cannot be empty!");
            _name = value;
        }
    }

    public string MemberId { get; }
    public int ActionCount => ActionLog.Count;
    protected List<string> ActionLog = new List<string>();

    public UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count >= 5)
            throw new Exception($"{Name} already hit the 5 action daily limit!");
    }
}