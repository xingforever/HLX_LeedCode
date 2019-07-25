using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _70.爬楼梯
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //https://leetcode-cn.com/problems/climbing-stairs/solution/pa-lou-ti-by-leetcode/
    //可以参考官方的 6个解法
    public class Solution
    {
        //斐波那契数
        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            int i1 = 1;
            int i2 = 2;
            for (int i = 3; i <= n; i++)
            {
                int temp = i1 + i2;
                i1 = i2;
                i2 = temp;
            }
            return i2;
        }
    }
}
