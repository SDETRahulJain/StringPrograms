using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    public class CountChar
    {
        //inputstring is aabbdbdfdwfd
        public string GetCounOfChar(string inputString)
        {
            StringBuilder output = new StringBuilder();

            Dictionary<char, int> uniqueHash = new Dictionary<char, int>();
            int counter = 0;
            foreach(char c in inputString)
            {
                if (!uniqueHash.ContainsKey(c))
                {
                    uniqueHash.Add(c, 1);

                }
                else
                {
                    uniqueHash[c]++;
                }
            }
            foreach( var c in uniqueHash)
            {
                output.Append(c.Key.ToString() + Int32.Parse(c.Value.ToString()));
            }

            return output.ToString();
        }
    }
}
