using System;

class Program
{
    static void Main(string[] args)
    {
        QuestProgram questProgram = new QuestProgram();

        
        Goal simpleGoal = new SimpleGoal("Run a marathon", 1000);
        Goal eternalGoal = new EternalGoal("Read scriptures", 100);
        Goal checklistGoal = new ChecklistGoal("Attend the temple", 50, 10);

        
        questProgram.AddGoal(simpleGoal);
        questProgram.AddGoal(eternalGoal);
        questProgram.AddGoal(checklistGoal);

        
        questProgram.RecordEvent("Run a marathon");
        questProgram.RecordEvent("Read scriptures");
        questProgram.RecordEvent("Attend the temple");
        questProgram.RecordEvent("Attend the temple");
        questProgram.RecordEvent("Attend the temple");

        
        questProgram.DisplayScore();
        questProgram.DisplayGoals();

        
        questProgram.SaveGoals();
        questProgram.LoadGoals();

        Console.ReadKey();
    }
}
