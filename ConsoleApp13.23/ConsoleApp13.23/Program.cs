using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._23
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = { 3.5, 12.2, 7.8, 4.4, 2.1 };

            ArrayProcessor processor = new ArrayProcessor(numbers);

            string result = processor.CountNumbersBetweenMinAndMax();

            Console.WriteLine(result);
        }
    }
}
