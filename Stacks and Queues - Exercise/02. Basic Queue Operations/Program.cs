using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] splitted = input.Split(' ').Select(int.Parse).ToArray();
            int n = splitted[0];
            int s = splitted[1];
            int x = splitted[2];
            Queue<int> queue = new Queue<int>();


            int[] numberInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (var item in numberInput)
            {
                queue.Enqueue(item);
            }

            queue.TrimExcess();




            if (s <= queue.Count)
            {
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }
            }

            bool inStack = false;

            foreach (var item in queue)
            {
                if (item == x)
                {
                    inStack = true;
                    continue;
                }
            }

            if (inStack == true)
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }


        }
    }
}
