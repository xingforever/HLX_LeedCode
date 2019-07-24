using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _485.最大连续1的个数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums=new int[]{ 1};
            var res =solution.FindMaxConsecutiveOnes(nums);
            Console.WriteLine(res);
        }
    }

    public class Solution
    {

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int length = 0;
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]==1)
                {
                    temp++;
                }
                else
                {
                    if (length<temp)
                    {
                        length = temp;
                    }
                    temp = 0;
                }
            }
            if (length < temp)
            {
                length = temp;
            }
            return length;
        }
    }
}
