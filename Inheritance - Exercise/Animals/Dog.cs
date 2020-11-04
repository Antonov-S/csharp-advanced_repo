using System;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        

        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
            
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ProduceSound());
            return sb.ToString();
        }
    }
}
