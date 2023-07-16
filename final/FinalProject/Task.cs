using System;

enum TaskPriority
{
    Low,
    Medium,
    High
}

enum TaskStatus
{
    Todo,
    InProgress,
    Completed
}

class BaseTask
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskStatus Status { get; set; }

    public BaseTask(string title, string description, DateTime dueDate, TaskPriority priority)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        Priority = priority;
        Status = TaskStatus.Todo;
    }

    public virtual void DisplayTaskDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Due Date: {DueDate}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine($"Status: {Status}");
    }
}
