using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Rectangle
    {
        private int length;
        private int width;
        public Rectangle() { }
        public Rectangle(int length)
        { this.Length = length; }
        public Rectangle(int length, int width) : this(length)
        {this.Width=width;}

        public int Length { get => length; set { 
                if (value < 0)
                    throw new ArgumentException("Error");
                length = value; }
            }
        public int Width { get => width; set { 
                if (value < 0)
                    throw new ArgumentException("Error");
                width = value;}
          }
        public void Info()
        {
            Console.WriteLine($"Длина:{Length} Длина:{Width}");
        }
        public override string ToString()
        {
            return $"Площадь{Length * Width:f1}\nПериметр:{2 * (Length * Width):f1}";
        }
    }
}
