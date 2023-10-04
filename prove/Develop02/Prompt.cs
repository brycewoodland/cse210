public class Prompt 
{

      private List<string> _journalPrompt = new List<string>();

      private void PresetPrompt() 
      {
        _journalPrompt.Add("Who was the most interesting person you interacted with today?");
        _journalPrompt.Add("What was the best part of your day?");
        _journalPrompt.Add("How did you see the hand of the Lord in your life today?");
        _journalPrompt.Add("What was the strongest emotion you felt today?");
        _journalPrompt.Add("If you had one thing you could do over today, what would it be?"); 
        _journalPrompt.Add("What were you nervous or anxious about today?");
        _journalPrompt.Add("What did you learn today?");
        _journalPrompt.Add("What were you grateful for today?");
        _journalPrompt.Add("What was the most surprising thing that happened today?");
        _journalPrompt.Add("What is a current problem or challenge you are facing?");
        }
        
        public string GetPrompt()
        {
          PresetPrompt();
          var random = new Random();
          int index = random.Next(_journalPrompt.Count);
          string journalPrompt = _journalPrompt[index];

          return journalPrompt;
        }
}