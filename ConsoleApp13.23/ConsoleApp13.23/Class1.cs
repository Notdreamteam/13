using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._23
{
    class ArrayProcessor
    {
        public double[] Numbers { get; set; }

        public ArrayProcessor(double[] numbers)
        {
            Numbers = numbers;
        }

        public string CountNumbersBetweenMinAndMax()
        {
            if (Numbers.Length < 2)
            {
                return "Массив слишком мал для определения минимального и максимального элементов.";
            }

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] < Numbers[minIndex])
                {
                    minIndex = i;
                }
                if (Numbers[i] > Numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int startIndex = Math.Min(minIndex, maxIndex);
            int endIndex = Math.Max(minIndex, maxIndex);

            int count = endIndex - startIndex - 1;

            if (count > 0)
            {
                return $"Количество чисел между минимальным и максимальным элементами: {count}";
            }
            else
            {
                return "Чисел между минимальным и максимальным элементами нет.";
            }
        }
    }
}
