using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс описывающий вычисления
    /// </summary>
    class Caclulate
    {
        /// <summary>
        /// Поле первого числа
        /// </summary>
        private double field1;
        /// <summary>
        /// Поле второго числа
        /// </summary>
        private double field2;

        public double Field1 { get => field1; set { if (value < 0) throw new ArgumentException("Error"); field1 = value; } }
        public double Field2 { get => field2; set { if (value < 0) throw new ArgumentException("Error"); field2 = value; } } 


        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Caclulate()
        { }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="field1">поле1</param>
        public Caclulate(double field1)
        {
            this.Field1 = field1;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="field1">поле1</param>
        /// <param name="field2">поле2</param>
        public Caclulate(double field1, double field2) :this(field1)
        {
            this.Field2 = field2;
        }
        public void Info()
        {
            Console.WriteLine($"field1={Field1}, field2={Field2}");
        }
        public double ToString()
        {
            return Math.Sqrt(Field1 * Field2);
        }
    }
}
