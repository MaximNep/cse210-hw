using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class BaseActivity
    {
        protected abstract string GetActivityName();

        protected abstract string GetActivityDescription();

        protected abstract int GetDuration();

        protected void ShowStartingMessage()
        {
            string activityName = GetActivityName();
            string activityDescription = GetActivityDescription();

            Console.WriteLine("=====================================");
            Console.WriteLine(activityName);
            Console.WriteLine("=====================================");
            Console.WriteLine(activityDescription);
            Console.WriteLine();

            Console.Write("Enter the duration in seconds: ");
        }

        protected void ShowFinishingMessage(int duration)
        {
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("Activity completed!");
            Console.WriteLine("Duration: {0} seconds", duration);
            Console.WriteLine("=====================================");
        }

        protected void ShowSpinner(int duration)
        {
            for (int i = 0; i < duration; i++)
            {
                Console.Write("/");
                Thread.Sleep(100);
                Console.Write("\b-");
                Thread.Sleep(100);
                Console.Write("\b\\");
                Thread.Sleep(100);
                Console.Write("\b|");
                Thread.Sleep(100);
                Console.Write("\b");
            }
            Console.WriteLine();
        }
    }
}
