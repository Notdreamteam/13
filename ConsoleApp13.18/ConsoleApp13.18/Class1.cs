using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._18
{
    class ArrayProcessor
    {
        public int[] Numbers { get; set; }

        public ArrayProcessor(int[] numbers)
        {
            Numbers = numbers;
        }

        private int CalculateIncreasingSum()
        {
            int sum = 0;
            int currentSum = Numbers[0];

            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] > Numbers[i - 1])
                {
                    currentSum += Numbers[i];
                }
                else
                {
                    if (currentSum != Numbers[i - 1])
                    {
                        sum += currentSum;
                    }
                    currentSum = Numbers[i];
                }
            }

            if (currentSum != Numbers[Numbers.Length - 1])
            {
                sum += currentSum;
            }

            return sum;
        }

        private int CalculateDecreasingSum()
        {
            int sum = 0;
            int currentSum = Numbers[0];

            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] < Numbers[i - 1])
                {
                    currentSum += Numbers[i];
                }
                else
                {
                    if (currentSum != Numbers[i - 1])
                    {
                        sum += currentSum;
                    }
                    currentSum = Numbers[i];
                }
            }

            if (currentSum != Numbers[Numbers.Length - 1])
            {
                sum += currentSum;
            }

            return sum;
        }

        public int CalculateDifference()
        {
            int increasingSum = CalculateIncreasingSum();
            int decreasingSum = CalculateDecreasingSum();

            return increasingSum - decreasingSum;
        }
    }
}
