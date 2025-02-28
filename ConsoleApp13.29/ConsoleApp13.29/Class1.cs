using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._29
{
    class BinaryCalculator
    {
        public string AddBinaryNumbers(string positiveBinary, string negativeBinary)
        {
            int positiveDecimal = Convert.ToInt32(positiveBinary, 2);
            int negativeDecimal = Convert.ToInt32(negativeBinary, 2);

            negativeDecimal = ~negativeDecimal + 1;

            int sum = positiveDecimal + negativeDecimal;

            return Convert.ToString(sum, 2);
        }
    }
}
