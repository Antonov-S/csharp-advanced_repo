using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> inputStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                inputStack.Push(input[i]);
            }

            while (inputStack.Count > 0)
            {
                Console.Write(inputStack.Pop());
            }
            Console.WriteLine();
            

        }
    }
}
