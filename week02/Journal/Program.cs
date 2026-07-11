using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string menu = "1. Write a new entry\n" +
                      "2. Display all entries\n" +
                      "3. Save entries to file\n" +
                      "4. Load entries from file\n" +
                      "5. Exit\n";

        Console.WriteLine("Welcome to the Journal Program!");
        
        bool running = true;
        while (running)
        {
            Console.Write(menu);
            string answer = Console.ReadLine();
            if (int.TryParse(answer, out int choice))
            {
               switch (choice)
                {
                    case 1:
                        // Write
                        Entry newEntry = new Entry();

                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.WriteLine();
                        Console.Write("Your response: ");
                        newEntry._entryText = Console.ReadLine();

                        newEntry._promptText = prompt;

                        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                        
                        journal.AddEntry(newEntry);
                        break;

                    case 2:
                        // Display
                        journal.DisplayAll();
                        break;

                    case 3:
                        // Save
                        Console.Write("Enter filename: ");
                        string saveFileName = Console.ReadLine();

                        journal.SaveToFile(saveFileName);
                        break;

                    case 4:
                        // Load
                        Console.Write("Enter filename: ");
                        string loadFileName = Console.ReadLine();

                        journal.LoadFromFile(loadFileName);
                        break;

                    case 5:
                        // Quit
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}