using _03._Hierarchical_Inheritance;
using System;

namespace Farm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dog sharo = new Dog();
            sharo.Eat();
            sharo.Bark();

            Cat meow = new Cat();
            meow.Eat();
            meow.Meow();

        }
    }
}
