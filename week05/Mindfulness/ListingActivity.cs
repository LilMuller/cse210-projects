public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();

        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> responses = GetListFromUser();

        GetListFromUser();

        DisplayEndingMessage();

        Console.WriteLine($"You listed {_count} items");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        _count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            responses.Add(response);

            _count++;
        }

        return responses;
    }
}