public class BreathingActivity : Activity {

    public BreathingActivity() : base("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Countdown()
    {
        Console.Write("Breathe in... ");
        GetTime();
        Console.WriteLine();
        Console.Write("Breathe out... ");
        GetTime();
    }

    public void DeepBreathing()
    {
        StartingMessage();
        SetTime();
        GetReady();
        Countdown();
        ClosingMessage();
    }
}