using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._18
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 2, 1, 4, 5, 3, 2 };

            ArrayProcessor processor = new ArrayProcessor(numbers);

            int difference = processor.CalculateDifference();

            Console.WriteLine($"Разность между суммой возрастающих и убывающих участков: {difference}");
        }
    }
}
