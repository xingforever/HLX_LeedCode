using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _40组合总和II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
             int [] data=new int[] { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
          var res =  solution.CombinationSum2(data,target);
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public List<int> Candidates; 
        public IList<IList<int>> res = new List<IList<int>>();     
     
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Candidates = candidates.ToList();
            Candidates.Sort();

            FindCombinationSum2(0, Candidates.Count, target, new Stack<int>());
            return res ;
        }
        // residue 表示剩余，这个值一开始等于 target，基于题目中说明的"所有数字（包括目标数）都是正整数"这个条件
        // residue 在递归遍历中，只会越来越小

        public void FindCombinationSum2( int begin, int len, int residue, Stack<int> stack)
        {
            if (residue==0)
            {
                res.Add(new List<int>(stack.ToList()));
                return;
            }
            for (int i = begin; i < len && residue - Candidates[i] >= 0; i++)
            {
                if (i > begin && Candidates[i] == Candidates[i - 1])
                {
                    continue;
                }
                stack.Push(Candidates[i]);
                // 【关键】因为元素不可以重复使用，这里递归传递下去的是 i + 1 而不是 i
                FindCombinationSum2(i + 1, len, residue - Candidates[i], stack);
                stack.Pop();

            }
        }
    }
}
