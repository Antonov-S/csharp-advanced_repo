using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPumps = int.Parse(Console.ReadLine());

            Queue<string> tour = new Queue<string>();

            for (int i = 0; i < numbersOfPumps; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                tour.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < numbersOfPumps; i++)
            {
                string currentInfo = tour.Dequeue();
                var splitedInfo = currentInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int refuel = splitedInfo[0];
                int distance = splitedInfo[1];
                totalFuel += refuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                tour.Enqueue(currentInfo);
            }

            var firstSuccesfoulRun = tour.Dequeue().Split().ToArray();
            Console.WriteLine(firstSuccesfoulRun[2]);

        }
    }
}
