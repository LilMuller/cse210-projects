using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Magic number between 1-100");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess;
        int count = 0;
        string response;

        do
        {
            do
            {
                Console.Write("What is your guess? ");
                string answer2 = Console.ReadLine();
                guess = int.Parse(answer2);
                count += 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed {count} times");
                }
            } while (!(magicNumber == guess));

            Console.Write("Do you want to play again?(yes/no) ");
            response = Console.ReadLine();
            count = 0;
            magicNumber = randomGenerator.Next(1, 100);
        } while (response == "yes");
        

        
    }
}