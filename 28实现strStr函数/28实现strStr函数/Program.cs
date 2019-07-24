using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28实现strStr函数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle=="")
            {
                return 0;
            }
            if (needle.Length>haystack.Length)
            {
                return -1;
            }
            if (needle.Length==haystack.Length)
            {
                if (needle==haystack)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            if (!haystack.Contains(needle))
            {
                return -1;
            }
            else
            {
                return haystack.IndexOf(needle);
            }
        }
    }
}
