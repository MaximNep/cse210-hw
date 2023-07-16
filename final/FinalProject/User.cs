using System;
using System.Collections.Generic;

class User
{
    public string Name { get; set; }
    public List<BaseTask> AssignedTasks { get; private set; }

    public User(string name)
    {
        Name = name;
        AssignedTasks = new List<BaseTask>();
    }

    public void DisplayAssignedTasks()
    {
        Console.WriteLine($"Tasks assigned to {Name}:");
        foreach (var task in AssignedTasks)
        {
            task.DisplayTaskDetails();
            Console.WriteLine("---------------");
        }
    }
}
