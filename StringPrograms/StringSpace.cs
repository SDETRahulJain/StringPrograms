using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class StringSpace
    {
        public string RemoveSpace(string inputString)
        {
            StringBuilder outputStringBuilder = new StringBuilder();
            foreach(char c in inputString)
            {
                if (c == ' ') continue;
                else
                    outputStringBuilder.Append(c);
            }
            return outputStringBuilder.ToString();
        }
    }
}
