using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Caclulate calc1 = new Caclulate();
            calc1.Info();
            Console.WriteLine($"{calc1.ToString()}");
            calc1.Field1 = 34;
            calc1.Field2 = 14;
            calc1.Info();
            Console.WriteLine($"{calc1.ToString()}");
            Caclulate calc2 = new Caclulate(9);
            calc2.Info();
            Caclulate calc3 = new Caclulate(9, 12);
            calc3.Info();
            Console.WriteLine($"{calc3.ToString()}");
            Console.Write($"Введите первое число: ");
            double field1 = double.Parse(Console.ReadLine());
            Console.Write($"Введите второе число: ");
            double field2 = double.Parse(Console.ReadLine());
            Caclulate calc4 = new Caclulate(field1, field2);
            Console.WriteLine($"{calc4.ToString()}");
            Console.ReadLine();
        }
    }
}
