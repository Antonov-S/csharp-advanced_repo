﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int count = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < children.Length; i++)
            {
                queue.Enqueue(children[i]);
            }

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}"); 
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");

            
        }
    }
}
