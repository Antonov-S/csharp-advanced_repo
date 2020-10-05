using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] inputOrders = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(inputOrders);

            Console.WriteLine(orders.Max());
            while (orders.Count > 0)
            {
                int currentOrder = orders.Peek();

                if (totalFood >= currentOrder)
                {
                    totalFood -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
                
            }

            if (orders.Count > 0)
            {
                Console.Write("Orders left: " + String.Join(" ", orders));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
