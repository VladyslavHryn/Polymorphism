public class UndergraduateStudent : UniversityMember
{
	public UndergraduateStudent(string name, string memberId) : base(name, memberId) {}
	public override void PerformDuties()
		base.PerformDuties();
		ActionLog.Add("Lab nwork completed");
		Console.WriteLine($"{Name} completed lab work (actions today: {ActionLog.Count})")
}