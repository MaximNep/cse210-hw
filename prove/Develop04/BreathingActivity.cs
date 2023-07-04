using System;

namespace MindfulnessApp
{
    public class BreathingActivity : BaseActivity
    {
        protected override string GetActivityName()
        {
            return "Breathing Activity";
        }

        protected override string GetActivityDescription()
        {
            return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override int GetDuration()
        {
            string input = Console.ReadLine();
            int duration;
            while (!int.TryParse(input, out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive integer.");
                Console.Write("Enter the duration in seconds: ");
                input = Console.ReadLine();
            }
            return duration;
        }

        public void Start()
        {
            ShowStartingMessage();

            int duration = GetDuration();
            int breathInDuration = duration / 2;
            int breathOutDuration = duration - breathInDuration;

            Console.WriteLine("Breathe in...");
            ShowSpinner(breathInDuration);

            Console.WriteLine("Breathe out...");
            ShowSpinner(breathOutDuration);

            ShowFinishingMessage(duration);
        }
    }
}
