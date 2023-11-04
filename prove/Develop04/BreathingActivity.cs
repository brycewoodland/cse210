public class BreathingActivity : Activity {

    public BreathingActivity() : base("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    private void Countdown(int seconds, string message)
    {
        Console.Write(message);
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i.ToString().PadLeft(2, ' '));
            Thread.Sleep(1000);
            Console.SetCursorPosition(message.Length, Console.CursorTop);
            if (i > 1)
            {
                Console.Write("");
            }
        }
        Console.WriteLine();
    }

    public void DeepBreathing()
    {
        StartingMessage();
        SetTime();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        while (DateTime.Now < futureTime)
        {
            Countdown(5, "Breathe in... ");
            Countdown(5, "Breathe out... ");
        }
        Console.Clear();
        ClosingMessage();
    }
}