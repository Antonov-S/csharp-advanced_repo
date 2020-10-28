using _02._Multiple_Inheritance;
using System;

namespace Farm

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            Console.WriteLine("puppy:");
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Console.WriteLine("cat:");
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
            Console.WriteLine("dog:");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }
}
