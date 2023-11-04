using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
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
                        ba.DeepBreathing();
                        break;
                    case 2:
                        ReflectingActivity ra = new ReflectingActivity();
                        ra.Reflect();
                        break;
                    case 3:
                        ListingActivity la = new ListingActivity();
                        la.List();
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("That was an invalid choice. Please try again.");
                        break;
                }
            }

        }

    }
}