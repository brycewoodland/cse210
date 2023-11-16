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
                            sg.CreateSimpleGoal();
                            goalTracker.AddGoal(sg);
                            break;
                        case "2":
                            EternalGoal eg = new EternalGoal();  
                            eg.CreateEternalGoal();
                            goalTracker.AddGoal(eg);
                            break;
                        case "3":
                            ChecklistGoal cg = new ChecklistGoal();
                            cg.CreateChecklistGoal();
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
                    goalTracker.SaveGoals();
                    break;
                case 4:
                    goalTracker.LoadGoals();
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