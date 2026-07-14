using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life.");

        Random random = new Random();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            int numberToHide = random.Next(1, 4);
            scripture.HideRandomWords(numberToHide);
        }
        Console.Clear();
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are now hidden!");
        }
    }
}