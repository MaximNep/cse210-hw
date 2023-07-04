using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("Mindfulness App");
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.WriteLine("=====================================");
                Console.Write("Enter your choice (1-4): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Start();
                        break;
                    case "2":
                        ReflectionActivity reflectionActivity = new ReflectionActivity();
                        reflectionActivity.Start();
                        break;
                    case "3":
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Start();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("=====================================");
                Console.WriteLine("Press any key to continue...");
                Console.WriteLine("=====================================");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
