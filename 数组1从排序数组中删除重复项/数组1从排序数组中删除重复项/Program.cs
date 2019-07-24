using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace 数组1从排序数组中删除重复项
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var res= solution.RemoveDuplicates2(nums);
            Console.WriteLine("个数 :" + res.ToString());
            for (int i = 0; i < res; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 给定的是排序数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            int startLen = nums.Length;
            List<int> needRemoveIndex = new List<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int num = nums[i];
                int num2 = nums[i + 1];
                if (num == num2)
                {
                    needRemoveIndex.Add(i + 1);
                }

            }
            List<int> res = new List<int>();
            int endLength = nums.Length - needRemoveIndex.Count;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (needRemoveIndex.Contains(i))
                {
                    continue;
                }
                nums[j] = nums[i];
                j++;
            }

            return endLength;
        }




        public int RemoveDuplicates2(int[] nums)
        {
            int startLen = nums.Length;
            int start = 0;
            int next = 1;
            int count = 0;
            int i = 1;
            while (start<nums.Length-1)
            {
                int num = nums[start];
                int num2 = nums[next];
                while (num2 == num)
                {
                    next += 1;
                    count += 1;
                    if (next <= nums.Length - 1)
                    {
                        num2 = nums[next];
                    }
                    else
                    {
                        next -= 1;
                        break;
                    }                    
                }
                
                start = next;
                next += 1;
                nums[i] = nums[start];
                i++;

            }
            return startLen - count;




        }

    }

}
