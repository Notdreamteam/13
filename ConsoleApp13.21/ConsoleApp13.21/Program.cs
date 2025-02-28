using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._21
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 5, 3, 8, 4, 2 };

            ArrayProcessor processor = new ArrayProcessor(numbers);

            var result = processor.FindElementsGreaterThanRight();

            Console.WriteLine("Индексы элементов, которые больше, чем элементы справа:");
            foreach (var index in result.Indices)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine($"Количество таких элементов: {result.Count}");
        }
    }
}
