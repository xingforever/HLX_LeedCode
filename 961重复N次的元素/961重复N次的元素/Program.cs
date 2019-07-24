using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _961重复N次的元素
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var data =new int[] { 5, 1, 5, 2, 5, 3, 5, 4 };
            solution.RepeatedNTimes(data);

        }
    }


    public class Solution
    {
        public int RepeatedNTimes(int[] A)
        {
            int count = A.Length / 2;
            var res = A.GroupBy(u => u).ToList();
            for (int i = 0; i < res.Count; i++)
            {
                var group = res[i];
                var gcount=group.Count();
                if (gcount==count)
                {
                    return res[i].Key;
                }
               
            }
            return 0;
        }


        public int RepeatedNTimes2(int[] A)
        {
            int count = A.Length / 2;
            Dictionary<int, int> group = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                var da = A[i];
                if (group.ContainsKey(da))
                {
                    group[da] += 1;
                }
                else
                {
                    group[da] = 1;
                }

            }
            foreach (var item in group.Keys)
            {
                if (group[item] == count)
                {
                    return item;
                }
            }
            return 0;
        }
    }
}
