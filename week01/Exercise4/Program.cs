using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberList = new List<int>();
        int numbers;
        int sum = 0;
        do
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            numbers = int.Parse(response);

            if (!(numbers == 0))
            {
                numberList.Add(numbers);
            }
            
        } while (!(numbers == 0));

        foreach (int num in numberList)
        {
            sum += num;
            
        }
        int average = sum / numberList.Count;
        int max = numberList.Max();
        var positives = numberList.Where(n => n > 0);
        int min = positives.Min();
        numberList.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine($"The sorted list is: {string.Join(" ", numberList)}");

    }
}