using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 打乱数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            Solution obj = new Solution(nums);
            int[] param_1 = obj.Reset();
            int[] param_2 = obj.Shuffle();
            for (int i = 0; i < param_2.Length; i++)
            {
                Console.WriteLine(param_2[i]);
            }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public readonly int[] oints;
        public int[] nums2;
        public int n;
        public Solution(int[] nums)
        {
            oints = nums;
            n = nums.Length;
            nums2 = (int [])nums.Clone();
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return oints;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            
            Random random = new Random();

            for (int i = n; i > 0; i--)
            {
                int randid = random.Next(i);
                swap(nums2, randid, i - 1);
            }


            return nums2;
        }
        public void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(nums);
     * int[] param_1 = obj.Reset();
     * int[] param_2 = obj.Shuffle();
     */
}
