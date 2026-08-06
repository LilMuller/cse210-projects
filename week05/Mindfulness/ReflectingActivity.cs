public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        InitializePrompts();
        InitializeQuestions();
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a significant challenge.",
            "Recall a moment when you helped someone in need.",
            "Reflect on a personal achievement that made you proud.",
            "Consider a time when you learned an important lesson from failure.",
            "Think about a situation where you demonstrated courage."
        };
    }

    private void InitializeQuestions()
    {
        _questions = new List<string>
        {
            "What did you learn from that experience?",
            "How did you feel when you accomplished that goal?",
            "What strengths do you now recognize in yourself?",
            "How can you apply what you learned to other areas of your life?",
            "What would you tell someone who is facing a similar challenge?"
        };
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        ShowSpinner(5);

        Console.WriteLine();
        Console.Write("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        int remainingTime = _duration;

        while (remainingTime > 0)
        {
            DisplayQuestion();

            int reflectionTime = Math.Min(10, remainingTime);
            ShowSpinner(reflectionTime);
            remainingTime -= reflectionTime;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }


    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine();
        Console.WriteLine("> " + GetRandomQuestion());
        Console.WriteLine();
    }
}