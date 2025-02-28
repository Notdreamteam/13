using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._21
{
    class ArrayProcessor
    {
        public int[] Numbers { get; set; }

        public ArrayProcessor(int[] numbers)
        {
            Numbers = numbers;
        }

        public (List<int> Indices, int Count) FindElementsGreaterThanRight()
        {
            List<int> indices = new List<int>();
            int count = 0;

            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                bool isGreater = true;

                for (int j = i + 1; j < Numbers.Length; j++)
                {
                    if (Numbers[i] <= Numbers[j])
                    {
                        isGreater = false;
                        break;
                    }
                }

                if (isGreater)
                {
                    indices.Add(i);
                    count++;
                }
            }

            if (Numbers.Length > 0)
            {
                indices.Add(Numbers.Length - 1);
                count++;
            }

            return (indices, count);
        }
    }
}
