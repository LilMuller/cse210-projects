public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        int remainingTime = _duration;

        //Enhanced the breathing algorithm to support any activity duration, including durations that are not divisible by the breathing cycle length.
        while (remainingTime > 0)
        {
            int inhaleTime = Math.Min(5, remainingTime);

            Console.WriteLine("Breathe in... ");
            ShowCountdown(inhaleTime);
            remainingTime -= inhaleTime;

            if (remainingTime <= 0)
                break;

            int exhaleTime = Math.Min(5, remainingTime);
            
            Console.WriteLine("Breathe out... ");
            ShowCountdown(exhaleTime);
            remainingTime -= exhaleTime;
        }

        DisplayEndingMessage();
    }
}