using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTODO List Management");
            Console.WriteLine("1. View tasks");
            Console.WriteLine("2. Add task");
            Console.WriteLine("3. Edit task");
            Console.WriteLine("4. Delete task");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    EditTask();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            Console.WriteLine("\nTasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter a new task: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("Task added.");
    }

    static void EditTask()
    {
        ViewTasks();
        Console.Write("Enter the number of the task you want to edit: ");
        int taskNumber;
        if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            Console.Write("Enter the new description for the task: ");
            tasks[taskNumber - 1] = Console.ReadLine();
            Console.WriteLine("Task updated.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    static void DeleteTask()
    {
        ViewTasks();
        Console.Write("Enter the number of the task you want to delete: ");
        int taskNumber;
        if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Task deleted.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
