public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override void Complete()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
        }
    }

    public override string GetProgress()
    {
        return IsCompleted ? "Completed" : "Not Completed";
    }
}
