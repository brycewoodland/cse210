using System;

class Program
{
    
    static void Main(string[] args)
    {
        int menuChoice = 0;

        while (menuChoice != 6)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out menuChoice))
        {
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("\nThe types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch (goalType) 
                    {
                        case "1":
                            Console.Write("What is the name of your goal? ");
                            string simpleName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string simpleDescrip = Console.ReadLine();
                            SimpleGoal sg = new SimpleGoal(simpleName, simpleDescrip);
                            Console.WriteLine();
                            sg.DisplayGoal();
                            break;
                        case "2":
                            Console.Write("What is the name of your goal? ");
                            string eternalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string eternalDescrip = Console.ReadLine();
                            EternalGoal eg = new EternalGoal(eternalName, eternalDescrip);
                            Console.WriteLine();
                            eg.DisplayGoal();
                            break;
                        case "3":
                            Console.Write("What is the name of your goal? ");
                            string checklistName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string checklistDescrip = Console.ReadLine();
                            ChecklistGoal cg = new ChecklistGoal(checklistName, checklistDescrip);
                            Console.WriteLine();
                            cg.DisplayGoal();
                            break;
                        default:
                            Console.WriteLine("That was an invalid choice. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("That was an invalid choice. Please try again.");
                    break;
            }
        }
        }
    }
}