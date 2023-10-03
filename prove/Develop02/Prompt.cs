public class Prompt 
{
      private static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?", 
        "What was I nervous or anxious about today?",
        "What did I learn today?",
        "What was I grateful for today?",
        "What was the most surprising thing that happened today?",
        "What is a current problem or challenge I am facing?"
        };

        private List<string> _journalPrompt = new List<string>(_prompt);

        public Prompt()
        {
            
        }
        
        public string GetPrompt()
        {
          var random = new Random();
          int index = random.Next(_journalPrompt.Count);
          string journalPrompt = _journalPrompt[index];

          return journalPrompt;
        }
}