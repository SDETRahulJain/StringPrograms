using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    public class StringToInt
    {
        public int StringToInteger(string str)
        {
            int num = 0;
            bool isNegative = false;
            int i = 0;

            // Check for negative sign
            if (str[0] == '-')
            {
                isNegative = true;
                i = 1;
            }

            // Iterate through the string and build the integer
            for (; i < str.Length; i++)
            {
                num *= 10;
                num += (int)(str[i] - '0');
            }

            // If the number is negative, convert it
            if (isNegative)
                num *= -1;

            return num;
        }
    }
}
