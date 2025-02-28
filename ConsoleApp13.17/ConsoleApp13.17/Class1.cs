using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._17
{
    class BinaryNumberProcessor
    {
        public char[] BinaryNumber { get; set; }

        public BinaryNumberProcessor(string binaryNumber)
        {
            BinaryNumber = binaryNumber.ToCharArray();
        }

        public void CyclicShiftRight()
        {
            char lastChar = BinaryNumber[BinaryNumber.Length - 1];
            for (int i = BinaryNumber.Length - 1; i > 0; i--)
            {
                BinaryNumber[i] = BinaryNumber[i - 1];
            }
            BinaryNumber[0] = lastChar;
        }

        public int BinaryToDecimal()
        {
            return Convert.ToInt32(new string(BinaryNumber), 2);
        }

        public int CalculateSum()
        {
            int originalNumber = BinaryToDecimal();

            CyclicShiftRight();

            int shiftedNumber = BinaryToDecimal();

            return originalNumber + shiftedNumber;
        }
    }

}
