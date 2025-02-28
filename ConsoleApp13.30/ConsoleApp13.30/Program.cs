using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._30
{
    internal class Program
    {
        static void Main()
        {
            int[] decimalArray = { 5, 10, 15 }; 
            DecimalToBinaryConverter converter = new DecimalToBinaryConverter(decimalArray);
            string[] binaryArray = converter.ConvertToBinary();

            Console.WriteLine("Binary representations:");
            for (int i = 0; i < binaryArray.Length; i++)
            {
                Console.WriteLine($"Decimal: {decimalArray[i]}, Binary: {binaryArray[i]}");
            }
        }
    }
}
