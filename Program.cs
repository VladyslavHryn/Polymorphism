class Program
{
    static void Main()
    {
        var registry = new UniversityRegistry();

        var profffesor = new Professor("Dr.Bob", "P001");
        var undergraduate = new UndergraduateStudent("Vlad", "U001");
        var graduate = new GraduateStudent("Oleksander", "G002");

        registry.AddMember(profffesor);
        registry.AddMember(undergraduate);
        registry.AddMember(graduate);

        Console.WriteLine("Round1");
        registry.ExecuteAllDuties();

        Console.WriteLine("Round 2");
        registry.ExecuteAllDuties();

        profffesor.ConductResearch("Mathematics");

        Console.WriteLine("" + registry.GetMemberStatistics());
    }
}