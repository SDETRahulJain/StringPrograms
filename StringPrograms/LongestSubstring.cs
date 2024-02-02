using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class LongestSubstring
    {
        public string FindLongestSubstring(string s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int left = 0, right = 0;
            int maxLen = 0;
            string result = "";

            while (right < n)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    right++;

                    if (right - left > maxLen)
                    {
                        maxLen = right - left;
                        result = s.Substring(left, maxLen);
                    }
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }

            return result;
        }
    }
}
