using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            int commandsCount = int.Parse(Console.ReadLine());
                        

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();
                string[] splittedCommand = command.Split().ToArray();

                switch (splittedCommand[0])
                {
                    case "1":
                        builder.Append(splittedCommand[1]);
                        stack.Push(builder.ToString());
                        break;
                    case "2":
                        int number = int.Parse(splittedCommand[1]);
                        builder.Remove(builder.Length - number, number);
                        stack.Push(builder.ToString());
                        break;
                    case "3":
                        int index = int.Parse(splittedCommand[1]);
                        Console.WriteLine(builder[index - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        builder = new StringBuilder();
                        builder.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}
