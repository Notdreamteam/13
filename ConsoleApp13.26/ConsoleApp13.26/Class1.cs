using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._26
{
    class BinaryArrayProcessor
    {
        public string[] BinaryNumbers { get; set; }

        public BinaryArrayProcessor(string[] binaryNumbers)
        {
            BinaryNumbers = binaryNumbers;
        }

        public void IncreaseByBinary1010()
        {
            int incrementValue = Convert.ToInt32("1010", 2);

            for (int i = 0; i < BinaryNumbers.Length; i++)
            {
                int currentValue = Convert.ToInt32(BinaryNumbers[i], 2);
                int newValue = currentValue + incrementValue;
                BinaryNumbers[i] = Convert.ToString(newValue, 2);
            }
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
