using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryCalculator calculator = new BinaryCalculator();

            Console.WriteLine("Введите положительное двоичное число:");
            string positiveBinary = Console.ReadLine();

            Console.WriteLine("Введите отрицательное двоичное число:");
            string negativeBinary = Console.ReadLine();

            string result = calculator.AddBinaryNumbers(positiveBinary, negativeBinary);

            Console.WriteLine($"Сумма в двоичной системе: {result}");
        }
    }
}
