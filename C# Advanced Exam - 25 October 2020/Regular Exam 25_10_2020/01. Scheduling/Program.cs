using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_tasks = Console.ReadLine();
            string input_threads = Console.ReadLine();
            int taskToKill = int.Parse(Console.ReadLine());

            int[] tasks = input_tasks.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] threads = input_threads.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackTasks = new Stack<int>(tasks);
            Queue<int> queueThreads = new Queue<int>(threads);

            while (queueThreads.Any() && stackTasks.Any())
            {
                int currentThread = queueThreads.Peek();
                int currentTask = stackTasks.Peek();

                if (currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", queueThreads));
                    break;
                }

                if (currentThread >= currentTask)
                {
                    stackTasks.Pop();
                    queueThreads.Dequeue();
                }
                else if (currentThread < currentTask)
                {
                    queueThreads.Dequeue();
                }


            }




        }
    }
}
