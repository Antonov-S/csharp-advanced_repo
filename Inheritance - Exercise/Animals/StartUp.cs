using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            List<Animal> animals = new List<Animal>();

            while ((command = Console.ReadLine()) != "Beast!")
            {
                

                try
                {

                    string[] token = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string name = token[0];
                    int age = int.Parse(token[1]);
                    string gender = token[2];

                    switch (command)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            animals.Add(cat);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            break;
                        case "Kittens":
                            Kitten kitten = new Kitten(name, age, gender);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age, gender);
                            animals.Add(tomcat);
                            break;
                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                }

                


            }

            foreach (var animal in animals)
            {
                string type = animal.GetType().ToString();
                type = type.Substring(8);
                Console.WriteLine(type);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ToString());

            }
        }

        
        
    }
}
