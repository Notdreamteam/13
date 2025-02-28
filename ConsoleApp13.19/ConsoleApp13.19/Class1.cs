using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._19
{
    class ArrayProcessor
    {
        public int[] Numbers { get; set; }

        public ArrayProcessor(int[] numbers)
        {
            Numbers = numbers;
        }

        public string CheckArithmeticProgression()
        {
            if (Numbers.Length < 2)
            {
                return "Массив слишком мал для определения прогрессии.";
            }

            int difference = Numbers[1] - Numbers[0];

            for (int i = 2; i < Numbers.Length; i++)
            {
                if (Numbers[i] - Numbers[i - 1] != difference)
                {
                    return "не образуют";
                }
            }

            return $"Образуют арифметическую прогрессию с разностью {difference}.";
        }
    }
}
