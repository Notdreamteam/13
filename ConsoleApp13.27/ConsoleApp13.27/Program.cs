using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._27
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = { 3.5, 1.2, 7.8, 4.4, 2.1 };

            Console.Write("Введите число R: ");
            double R = Convert.ToDouble(Console.ReadLine());

            ArrayProcessor processor = new ArrayProcessor(numbers);

            var result = processor.FindClosestElement(R);

            Console.WriteLine($"Наиболее близкий элемент: {result.Value} (индекс: {result.Index})");
        }
    }
}
