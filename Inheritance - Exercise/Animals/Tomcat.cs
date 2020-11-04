using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string DefaultGender = "Male";

        

        public Tomcat(string name, int age, string gender)
            : base(name, age, gender)
        {
            this.Gender = DefaultGender;
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ProduceSound());
            return sb.ToString();
        }


    }
}
