using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        int pick;
        string menu = "Menu(Chose 1-4) \n1. Breathing Activity \n2. Reflecting Activity \n3. Listing Activity \n4. Exit \n";
        while (true)
        {
            Console.WriteLine(menu);
            Console.Write("> ");
            pick = int.Parse(Console.ReadLine());

            if (pick == 1)
            {
                breathingActivity.Run();
            }else if(pick == 2)
            {
                reflectingActivity.Run();
            }else if (pick == 3)
            {
                listingActivity.Run();
            }else if (pick == 4)
            {
                Console.WriteLine("Goodbye!");
                break;                
            }else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }    
        }
    }
}