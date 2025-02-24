using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Length=23;
            rect1.Width=13;
            rect1.Info();
            Console.WriteLine($"{rect1.ToString()}");
            Console.WriteLine();
            Rectangle rect2 = new Rectangle(4,2);
            rect2.Info();
            Console.WriteLine($"{rect2.ToString()}");
            Console.WriteLine();
            Console.Write("Длина: ");
            int Length = int.Parse(Console.ReadLine());
            Console.Write("Ширина: ");
            int Width = int.Parse(Console.ReadLine());
            Rectangle rect3 = new Rectangle(Length, Width);
            Console.WriteLine($"{rect3.ToString()}");
            Console.ReadLine();
        }
    }
}
