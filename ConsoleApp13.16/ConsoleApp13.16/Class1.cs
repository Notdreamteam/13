using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._16
{
    class BinaryArrayProcessor
    {
        public string[] BinaryNumbers { get; set; }

        public BinaryArrayProcessor(string[] binaryNumbers)
        {
            BinaryNumbers = binaryNumbers;
        }

        private int BinaryToDecimal(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        private int FindMinIndex()
        {
            int minIndex = 0;
            int minValue = BinaryToDecimal(BinaryNumbers[0]);

            for (int i = 1; i < BinaryNumbers.Length; i++)
            {
                int currentValue = BinaryToDecimal(BinaryNumbers[i]);
                if (currentValue < minValue)
                {
                    minValue = currentValue;
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private int FindMaxIndex()
        {
            int maxIndex = 0;
            int maxValue = BinaryToDecimal(BinaryNumbers[0]);

            for (int i = 1; i < BinaryNumbers.Length; i++)
            {
                int currentValue = BinaryToDecimal(BinaryNumbers[i]);
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public void SwapMinAndMax()
        {
            int minIndex = FindMinIndex();
            int maxIndex = FindMaxIndex();

            string temp = BinaryNumbers[minIndex];
            BinaryNumbers[minIndex] = BinaryNumbers[maxIndex];
            BinaryNumbers[maxIndex] = temp;
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
