using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Gosho");
            list.Add("Pesho");
            list.Add("Sasho");
            list.Add("Gero");
            list.Add("Mero");

            Console.WriteLine(list.Count);
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.Count);

        }
    }
}
