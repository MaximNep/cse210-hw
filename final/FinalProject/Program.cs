using System;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        User user1 = new User("John");
        User user2 = new User("Jane");

        BaseTask task1 = new BaseTask("Task 1", "Complete the report", DateTime.Now.AddDays(5), TaskPriority.Medium);
        BaseTask task2 = new BaseTask("Task 2", "Fix bugs in the code", DateTime.Now.AddDays(3), TaskPriority.High);

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        taskManager.AssignTask(task1, user1);
        taskManager.AssignTask(task2, user2);

        task1.DisplayTaskDetails();
        Console.WriteLine("--------------------");
        user1.DisplayAssignedTasks();

        taskManager.UpdateTaskStatus(task1, TaskStatus.Completed);

        Console.WriteLine("\nAll tasks in the Task Manager:");
        taskManager.DisplayAllTasks();
    }
}
