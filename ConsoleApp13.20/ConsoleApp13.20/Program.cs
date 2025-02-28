using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._20
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 2, 4, 8, 16, 32 };

            ArrayProcessor processor = new ArrayProcessor(numbers);

            string result = processor.CheckGeometricProgression();

            Console.WriteLine(result);
        }
    }
}
