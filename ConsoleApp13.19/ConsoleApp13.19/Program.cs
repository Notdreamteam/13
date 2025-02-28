using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._19
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            ArrayProcessor processor = new ArrayProcessor(numbers);

            string result = processor.CheckArithmeticProgression();

            Console.WriteLine(result);
        }
    }
}
