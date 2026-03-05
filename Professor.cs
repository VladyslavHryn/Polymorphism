public class Professor : UniversityMemeber
{
    public Professor(string name, string memberId) : base(name, memberId) {}
    
    public override void PerformDuties()
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
        Console.WriteLine($"{Name} delivered a lecture (actions today: {ActionLog.Count})")
    

public void ConductResearch(string topic)
{
    Console.WriteLine($"{Name} is now researching: {topic}");
}

}