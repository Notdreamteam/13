using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._30
{
    class DecimalToBinaryConverter
    {
        private int[] decimalArray;

        public DecimalToBinaryConverter(int[] decimalArray)
        {
            this.decimalArray = decimalArray;
        }

        public string[] ConvertToBinary()
        {
            return decimalArray.Select(ConvertToBinaryString).ToArray();
        }

        private string ConvertToBinaryString(int number)
        {
            return Convert.ToString(number, 2);
        }
    }

}
