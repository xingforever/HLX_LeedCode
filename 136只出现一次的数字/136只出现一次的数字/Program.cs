using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136只出现一次的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 2, 2, 1 };
            Solution solution = new Solution();
            var res=solution.SingleNumber(data);
            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int a = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                a ^= nums[i];
            }
            return a;
        }
    }
}
