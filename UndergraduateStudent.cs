using System;

public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string memberId) : base(name, memberId) { }

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lab work completed");
        Console.WriteLine($"{Name} finished lab work (actions today: {ActionLog.Count})");
    }
}