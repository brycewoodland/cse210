using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> excerciseList = new List<Activity>();

        Run r = new Run("03 Nov 2022", 388, 26.2);
        excerciseList.Add(r);

        Cycle c = new Cycle("03 Nov 2022", 276, 25);
        excerciseList.Add(c);

        Swim s = new Swim("03 Nov 2022", 78, 40);
        excerciseList.Add(s);

        foreach (Activity exercise in excerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}