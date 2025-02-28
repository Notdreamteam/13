using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._20
{
    class ArrayProcessor
    {
        public int[] Numbers { get; set; }

        public ArrayProcessor(int[] numbers)
        {
            Numbers = numbers;
        }

        public string CheckGeometricProgression()
        {
            if (Numbers.Length < 2)
            {
                return "Массив слишком мал для определения прогрессии.";
            }

            if (Numbers[0] == 0)
            {
                return "не образуют"; 
            }

            double ratio = (double)Numbers[1] / Numbers[0];

            for (int i = 2; i < Numbers.Length; i++)
            {
                if (Numbers[i - 1] == 0)
                {
                    return "не образуют"; 
                }

                double currentRatio = (double)Numbers[i] / Numbers[i - 1];
                if (Math.Abs(currentRatio - ratio) > 0.0001)
                {
                    return "не образуют";
                }
            }

            return $"Образуют геометрическую прогрессию со знаменателем {ratio}.";
        }
    }
}
