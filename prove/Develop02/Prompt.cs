public class Prompt 
{

      private List<string> _journalPrompt = new List<string>();

      public Prompt()
      {

      }
      private void PresetPrompt() 
      {
        _journalPrompt.Add("Who was the most interesting person I interacted with today?");
        _journalPrompt.Add("What was the best part of my day?");
        _journalPrompt.Add("How did I see the hand of the Lord in my life today?");
        _journalPrompt.Add("What was the strongest emotion I felt today?");
        _journalPrompt.Add("If I had one thing I could do over today, what would it be?"); 
        _journalPrompt.Add("What was I nervous or anxious about today?");
        _journalPrompt.Add("What did I learn today?");
        _journalPrompt.Add("What was I grateful for today?");
        _journalPrompt.Add("What was the most surprising thing that happened today?");
        _journalPrompt.Add("What is a current problem or challenge I am facing?");
        }
        
        public string GetPrompt()
        {
          PresetPrompt();
          var random = new Random();
          int index = random.Next(_journalPrompt.Count);

          return _journalPrompt[index];
        }

        public void DisplayPrompt()
        {
          Console.WriteLine();
          Console.WriteLine($"{_journalPrompt}");
        }
}