public class PromptGenerator
{
    public List<string> _prompts = new();

    public PromptGenerator()
    {
       _prompts.Add("Who was the most interesting person I interacted with today?"); 
       _prompts.Add("What was the best part of my day?");
       _prompts.Add("How did I see the hand of the Lord in my life today?");
       _prompts.Add("What was the strongest emotion I felt today?");
       _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetPrompt()
    {
        Random  number = new();
        int sortNumber = number.Next(_prompts.Count);
        string prompt = _prompts[sortNumber];
        
        return prompt;
    }   
}