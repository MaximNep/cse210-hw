using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : BaseActivity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        protected override string GetActivityName()
        {
            return "Listing Activity";
        }

        protected override string GetActivityDescription()
        {
            return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            string prompt = prompts[index];
            return prompt;
        }

        public void Start()
        {
            ShowStartingMessage();

            int duration = GetDuration();
            string prompt = GetRandomPrompt();

            Console.WriteLine(prompt);
            Thread.Sleep(5000);

            Console.WriteLine();
            Console.WriteLine("Begin listing...");
            Thread.Sleep(2000);

            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Number of items listed: {0}", items.Count);

            ShowFinishingMessage
