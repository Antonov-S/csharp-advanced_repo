using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Dogo methods:");
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            Console.WriteLine("Cat's methods:");
            cat.Eat();
            cat.Meow(); 
        }
    }
}
