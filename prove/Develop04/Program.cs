using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: 
                        BreathingActivity ba = new BreathingActivity();
                        ba.StartingMessage();
                        break;
                    case 2:
                        ReflectingActivity ra = new ReflectingActivity();
                        ra.StartingMessage();
                        break;
                    case 3:
                        ListingActivity la = new ListingActivity();
                        la.StartingMessage();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("That was an invalid choice.");
                        break;
                }
            }

        }

    }
}