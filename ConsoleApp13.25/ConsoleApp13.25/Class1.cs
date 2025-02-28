using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._25
{
    class BinaryArrayProcessor
    {
        public string[] BinaryNumbers { get; set; }

        public BinaryArrayProcessor(string[] binaryNumbers)
        {
            BinaryNumbers = binaryNumbers;
        }

        public void CyclicShiftLeft()
        {
            if (BinaryNumbers.Length == 0)
            {
                return; 
            }

            string firstElement = BinaryNumbers[0];

            for (int i = 0; i < BinaryNumbers.Length - 1; i++)
            {
                BinaryNumbers[i] = BinaryNumbers[i + 1];
            }

            BinaryNumbers[BinaryNumbers.Length - 1] = firstElement;
        }

        public int CalculateSum()
        {
            int sum = 0;
            foreach (var number in BinaryNumbers)
            {
                sum += Convert.ToInt32(number, 2); 
            }
            return sum;
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
