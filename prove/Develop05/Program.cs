using System;
using System.Data.SqlTypes;

class Program
{
    
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        int menuChoice = 0;

        while (menuChoice != 6)
        {
            goalTracker.DisplayPoints();
            Console.WriteLine();

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
                    Console.WriteLine("3. Checklist Goal\n");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch (goalType) 
                    {
                        case "1": 
                            SimpleGoal sg = new SimpleGoal(); 
                            sg.CreateChildGoal();
                            goalTracker.AddGoal(sg);
                            break;
                        case "2":
                            EternalGoal eg = new EternalGoal();  
                            eg.CreateChildGoal();
                            goalTracker.AddGoal(eg);
                            break;
                        case "3":
                            ChecklistGoal cg = new ChecklistGoal();
                            cg.CreateChildGoal();
                            goalTracker.AddGoal(cg);
                            break;
                        default:
                            Console.WriteLine("That was an invalid choice. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    goalTracker.DisplayAllGoals();
                    break;
                case 3:
                    Console.WriteLine();
                    goalTracker.SaveGoals();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    goalTracker.LoadGoals();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine();
                    goalTracker.RecordEventForGoal();
                    break;
                case 6:
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