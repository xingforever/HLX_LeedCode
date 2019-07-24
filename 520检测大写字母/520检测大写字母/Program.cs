using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _520检测大写字母
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res=solution.DetectCapitalUse("Google");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
          
            int temp=0;
            for (int i = 0; i < word.Length; i++)
            {
                var w = word[i];
                if (w<97)
                {
                    temp++;
                }
            }
            if (temp==word.Length||temp==0)
            {
                return true;
            }
            if (word[0]<97&&temp==1)
            {
                return true;
            }
            return false;

        }
    }
}
