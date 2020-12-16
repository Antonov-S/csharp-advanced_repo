using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] roses = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[] lilies = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue = new Queue<int>(roses);

            int wreathsCount = 0;
            int storedFlowers = 0;

            while (liliesStack.Any() && rosesQueue.Any())
            {
                int currentLilie = liliesStack.Peek();
                int currentRoses = rosesQueue.Peek();
                int sumOfcurrentFlowers = currentLilie + currentRoses;

                if (sumOfcurrentFlowers == 15)
                {
                    wreathsCount++;
                    liliesStack.Pop();
                    rosesQueue.Dequeue();

                }
                else if (sumOfcurrentFlowers >= 15)
                {
                    liliesStack.Push(liliesStack.Pop() - 2);
                }
                else
                {
                    storedFlowers += liliesStack.Pop() + rosesQueue.Dequeue();
                }
            }

            wreathsCount += storedFlowers / 15;

            Console.WriteLine(wreathsCount >= 5 ?
                $"You made it, you are going to the competition with {wreathsCount} wreaths!" :
                $"You didn't make it, you need {5 - wreathsCount} wreaths more!");

        }
    }
}
