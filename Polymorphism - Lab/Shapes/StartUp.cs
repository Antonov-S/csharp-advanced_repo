using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape sh = new Rectangle(7, 8);
            Console.WriteLine(sh.Draw());
            Console.WriteLine(sh.CalculateArea());
            Console.WriteLine(sh.CalculatePerimeter());
        }
    }
}
