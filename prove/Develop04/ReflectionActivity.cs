using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ReflectionActivity : BaseActivity
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        protected override string GetActivityName()
        {
            return "Reflection Activity";
        }

        protected override string GetActivityDescription()
        {
            return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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

        private string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(questions.Count);
            string question = questions[index];
            return question;
        }

        public void Start()
        {
            ShowStartingMessage();

            int duration = GetDuration();
            string prompt = GetRandomPrompt();

            Console.WriteLine(prompt);
            Thread.Sleep(5000);

            Console.WriteLine();
            Console.WriteLine("Begin reflecting...");
            Thread.Sleep(2000);

            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                string question = GetRandomQuestion();
                Console.WriteLine(question);
                ShowSpinner(5);
                Console.WriteLine();
            }

            ShowFinishingMessage(duration);
        }
    }
}
