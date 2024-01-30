using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class UniqueChar
    {
        public string GetUniqueChar(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> uniqueChars = new HashSet<char>();
            foreach (char c in inputString)
            {
                if (!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                    sb.Append(c);
                }
                

               
            }
            return sb.ToString();
        }
    }
}
