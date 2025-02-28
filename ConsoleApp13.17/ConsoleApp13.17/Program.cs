using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._17
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите двоичное число: ");
            string binaryNumber = Console.ReadLine();

            BinaryNumberProcessor processor = new BinaryNumberProcessor(binaryNumber);

            int sum = processor.CalculateSum();

            Console.WriteLine($"Сумма исходного и сдвинутого числа: {sum}");
        }
    }
}
