using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    internal class LonestSS
    {
        public int lenOfLongSS(string s)
        {
            var set = new HashSet<char>();
            int left = 0; 
            int maxL = 0;

            for (int i = 0; i < s.Length; i++)
            {
                while (set.Contains(s[i]))
                {
                    set.Remove(s[left]);
                    left++;

                }
                set.Add(s[i]);
                maxL=Math.Max(maxL, i-left+1);
            }
            return maxL;
        }
    }
}
