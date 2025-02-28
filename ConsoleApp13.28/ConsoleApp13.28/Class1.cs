using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._28
{
    class BinaryArray
    {
        private int[] binaryArray;

        public BinaryArray(int[] array)
        {
            binaryArray = array;
        }

        public (int index, int value) FindFurthestFrom(int d)
        {
            int maxDistance = -1;
            int furthestIndex = -1;
            int furthestValue = -1;

            for (int i = 0; i < binaryArray.Length; i++)
            {
                int distance = Math.Abs(binaryArray[i] - d);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    furthestIndex = i;
                    furthestValue = binaryArray[i];
                }
            }

            return (furthestIndex, furthestValue);
        }
    }

}
