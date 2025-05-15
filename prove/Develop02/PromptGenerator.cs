public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "What is a small joy you experienced today?",
        "Describe a person who inspires you and why.",
        "What is a goal you are currently working towards? What are the steps you're taking?",
        "If you could have any superpower for a day, what would it be and how would you use it?",
        "What is a belief you once held strongly that has changed over time?",
        "Describe a place that holds special meaning for you.",
        "What is something you are proud of accomplishing recently?",
        "What is a skill you would like to learn or improve?",
        "Write about a moment when you felt truly alive.",
        "What is a challenge you are currently facing, and how are you approaching it?",
        "What is a piece of advice you would give to your younger self?",
        "Describe a dream you remember vividly.",
        "What are three things you are grateful for right now?",
        "If you could travel anywhere in the world tomorrow, where would you go and why?",
        "What is a small act of kindness you witnessed or performed recently?",
        "What is a lesson you learned from a mistake?",
        "Describe a sound that you find comforting.",
        "What is something you are looking forward to in the coming week?",
        "Write about a time when you had to make a difficult decision.",
        "What is a question you are currently pondering?"
    };
    int _randomIndex;

    public string GetPrompt()
    {
        Random random = new Random();

        _randomIndex = random.Next(_prompts.Count);

        return _prompts[_randomIndex];
    }
}