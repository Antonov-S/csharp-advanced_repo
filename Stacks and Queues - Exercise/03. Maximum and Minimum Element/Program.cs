using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                switch (input[0])
                {
                    case (1):
                        stack.Push(input[1]);
                        break;
                    case (2):
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            stack.Pop();
                        }
                        break;
                    case (3):
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case (4):
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            
            Console.Write(String.Join(", ", stack));
            
            
            Console.WriteLine();
        }
    }
}
