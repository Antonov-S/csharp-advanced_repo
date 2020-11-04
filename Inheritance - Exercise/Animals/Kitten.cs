using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string DefaultGender = "Female";

        

        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
            this.Gender = DefaultGender;
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ProduceSound());
            return sb.ToString();
        }
    }
}
