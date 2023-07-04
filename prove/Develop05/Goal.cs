public abstract class Goal
{
    public string Name { get; private set; }
    public int Value { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        Value = 0;
        IsCompleted = false;
    }

    public abstract void Complete();

    public abstract string GetProgress();

    public virtual string GetDetails()
    {
        return $"{Name} ({GetProgress()}) - {Value} points";
    }
}
