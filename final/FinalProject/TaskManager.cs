using System;
using System.Collections.Generic;

class TaskManager
{
    public List<BaseTask> Tasks { get; private set; }
    public List<User> Users { get; private set; }

    public TaskManager()
    {
        Tasks = new List<BaseTask>();
        Users = new List<User>();
    }

    public void AddTask(BaseTask task)
    {
        Tasks.Add(task);
    }

    public void AssignTask(BaseTask task, User user)
    {
        task.Status = TaskStatus.InProgress;
        user.AssignedTasks.Add(task);
    }

    public void UpdateTaskStatus(BaseTask task, TaskStatus status)
    {
        task.Status = status;
    }

    public void DisplayAllTasks()
    {
        foreach (var task in Tasks)
        {
            task.DisplayTaskDetails();
            Console.WriteLine("---------------");
        }
    }
}
