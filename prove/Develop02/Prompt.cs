public class Prompt 
{

      private List<string> journalPrompt = new List<string>();
      private void PresetPrompt() 
      {
        journalPrompt.Add("Who was the most interesting person I interacted with today?");
        journalPrompt.Add("What was the best part of my day?");
        journalPrompt.Add("How did I see the hand of the Lord in my life today?");
        journalPrompt.Add("What was the strongest emotion I felt today?");
        journalPrompt.Add("If I had one thing I could do over today, what would it be?"); 
        journalPrompt.Add("What was I nervous or anxious about today?");
        journalPrompt.Add("What did I learn today?");
        journalPrompt.Add("What was I grateful for today?");
        journalPrompt.Add("What was the most surprising thing that happened today?");
        journalPrompt.Add("What is a current problem or challenge I am facing?");
        }
        
        public string GetPrompt()
        {
          PresetPrompt();
          var random = new Random();
          int index = random.Next(journalPrompt.Count);

          return journalPrompt[index];
        }
}