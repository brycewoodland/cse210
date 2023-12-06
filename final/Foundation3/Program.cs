using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Suwannee Circle", "Murray", "Utah", "84123");
        Lecture le = new Lecture("Lecture", "We listen to a speaker speak words", "2023-12-05", "7:00 P.M.", a1, "Bryce Woodland", 100);
        OutdoorGathering og = new OutdoorGathering("Outdoor Gathering", "We gather in the great outdoors!", "2023-12-07", "6:00 P.M.", a1, "Sunny");
        Reception r = new Reception("Reception", "Marriage is what bwings us together today!", "2023-12-09", "5:00 P.M.", a1, "bwoodlan@byui.edu");

        le.StandardDetails();
        Console.WriteLine();
        le.ShortDescription();
        Console.WriteLine();
        le.LectureDetails();
        Console.WriteLine();

        og.StandardDetails();
        Console.WriteLine();
        og.ShortDescription();
        Console.WriteLine();
        og.OutdoorGatheringDetails();
        Console.WriteLine();

        r.StandardDetails();
        Console.WriteLine();
        r.ShortDescription();
        Console.WriteLine();
        r.ReceptionDetails();
    }
}