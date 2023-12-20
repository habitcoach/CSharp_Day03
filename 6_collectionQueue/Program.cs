using System;
using System.Collections.Generic;

namespace collectionQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Queue to store tasks (strings in this case)
            Queue<string> tasks = new Queue<string>();

            // Enqueue tasks to the queue
            tasks.Enqueue("Task 1");
            tasks.Enqueue("Task 2");
            tasks.Enqueue("Task 3");
            tasks.Enqueue("Task 4");

            

            // Display all tasks in the queue
            Console.WriteLine("Tasks in the queue:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            // Dequeue and process tasks from the queue
            while (tasks.Count > 0)
            {
                string currentTask = tasks.Dequeue();
                Console.WriteLine($"\nProcessing: {currentTask}");
                // Simulate some work being done with the task
                System.Threading.Thread.Sleep(2000); // 1 second delay
                Console.WriteLine("Task completed.");
            }

            Console.WriteLine("\nAll tasks have been processed.");

            Console.WriteLine("Tasks in the queue:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task); // will give empty queue as all the value in the queue are dequeued
            }

            Console.ReadLine();
        }
    }
}
