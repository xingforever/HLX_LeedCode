using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _888公平的糖果交换
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            var sum1 = A.Sum();
            var sum2 = B.Sum();
            var evg = (sum1 + sum2) / 2;
            int[] res = new int[2];
            bool isMax1 = sum1 > sum2 ? true : false;
            int needChange = Math.Abs(evg - sum2);
            for (int i = 0; i < B.Length; i++)
            {
                var data = B[i];
                int needValue = 0;
                if (isMax1)
                {
                    needValue = needChange - data;
                    if (A.Contains(needValue))
                    {
                        res[0] = needValue;
                        res[1] = data;
                    }
                }
                else
                {
                    needValue = data-needChange ;
                    if (A.Contains(needValue))
                    {
                        res[0] = needValue;
                        res[1] = data;
                    }
                }

                
            }

        }
    }
}
