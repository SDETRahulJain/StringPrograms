using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class ReverseStringWithoutWords
    {
        public string GetRverseStringWithoutWords(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            string[] strings = inputString.Split(' ');
            for(int index = strings.Length - 1; index >= 0; index--)
            {
                sb.Append(strings[index]);
                sb.Append(" ");
            }



            return sb.ToString().Trim();

        }
    }
}
