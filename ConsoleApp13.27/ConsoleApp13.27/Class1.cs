using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._27
{
    class ArrayProcessor
    {
        public double[] Numbers { get; set; }

        public ArrayProcessor(double[] numbers)
        {
            Numbers = numbers;
        }

        public (double Value, int Index) FindClosestElement(double R)
        {
            if (Numbers.Length == 0)
            {
                throw new InvalidOperationException("Массив пуст.");
            }

            double closestValue = Numbers[0];
            int closestIndex = 0;
            double minDifference = Math.Abs(Numbers[0] - R);

            for (int i = 1; i < Numbers.Length; i++)
            {
                double currentDifference = Math.Abs(Numbers[i] - R);
                if (currentDifference < minDifference)
                {
                    minDifference = currentDifference;
                    closestValue = Numbers[i];
                    closestIndex = i;
                }
            }

            return (closestValue, closestIndex);
        }
    }
}
