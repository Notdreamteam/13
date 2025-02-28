using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._24
{
    class BinaryArrayProcessor
    {
        public string[] BinaryNumbers { get; set; }

        public BinaryArrayProcessor(string[] binaryNumbers)
        {
            BinaryNumbers = binaryNumbers;
        }

        public void CyclicShiftRight()
        {
            if (BinaryNumbers.Length == 0)
            {
                return; 
            }

            string lastElement = BinaryNumbers[BinaryNumbers.Length - 1];

            for (int i = BinaryNumbers.Length - 1; i > 0; i--)
            {
                BinaryNumbers[i] = BinaryNumbers[i - 1];
            }

            BinaryNumbers[0] = lastElement;
        }

        public void PrintArray()
        {
            Console.WriteLine("Массив двоичных чисел:");
            foreach (var number in BinaryNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
