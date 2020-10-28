
using System;

namespace Farm

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog's metods:");
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            Console.WriteLine("Cat's metods:");
            cat.Eat();
            cat.Meow();

        }
    }
}
