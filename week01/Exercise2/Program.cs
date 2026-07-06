using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        int lastDigit = gradePercentage % 10;
        if (!(gradePercentage >= 90 || gradePercentage < 60))
        {
            if (lastDigit >= 7)
            {
                letter += "+";
            }else if (lastDigit < 3)
            {
                letter += "-";
            }
        }
        Console.WriteLine($"Your grade is: {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Try harder next time");
        }
    }
}