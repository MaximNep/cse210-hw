public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completionCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name)
    {
        Value = value;
        this.targetCount = targetCount;
        completionCount = 0;
    }

    public override void Complete()
    {
        completionCount++;
        Value += completionCount;

        if (completionCount == targetCount)
        {
            Value += 500; 
            IsCompleted = true;
        }
    }

    public override string GetProgress()
    {
        return $"Completed {completionCount}/{targetCount} times";
    }

    public override string GetDetails()
    {
        return $"{base.GetDetails()} ({completionCount}/{targetCount} times completed)";
    }
}
