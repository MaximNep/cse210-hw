using System;
using System.Collections.Generic;

public class QuestProgram
{
    private List<Goal> goals;
    private int totalScore;

    public QuestProgram()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.Complete();
            totalScore += goal.Value;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine("Total Score: " + totalScore);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void SaveGoals()
    {
        // Code to save goals to a file or database
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        // Code to load goals from a file or database
        Console.WriteLine("Goals loaded.");
    }
}
