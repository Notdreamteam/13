using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._26
{
    internal class Program
    {
        static void Main()
        {
            string[] binaryNumbers = { "1010", "1100", "1001", "1111", "1011" };

            BinaryArrayProcessor processor = new BinaryArrayProcessor(binaryNumbers);

            Console.WriteLine("Исходный массив:");
            processor.PrintArray();

            processor.IncreaseByBinary1010();

            Console.WriteLine("\nМассив после увеличения на 1010:");
            processor.PrintArray();
        }
    }
}
