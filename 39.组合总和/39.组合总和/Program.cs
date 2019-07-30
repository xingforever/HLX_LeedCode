using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _39.组合总和
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] candidates =new int[] { 2, 3, 6, 7 };
            int target = 7;
            var res=solution.CombinationSum(candidates,target);            
            Console.WriteLine();
            Console.ReadKey();
        }
    }



    public class Solution
    {
        public List<IList<int>> res = new List<IList<int>>();
        List<int> CombinationList = new List<int>();
        Stack<int> dataList = new Stack<int>();
     
        private int len;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            CombinationList = candidates.ToList();
            CombinationList.Sort();
            len = CombinationList.Count;        
            findCombinationSum(target,0,  new Stack<int>());
            return res;
        }

        public  void findCombinationSum(int residue, int start, Stack<int> dataList)
        {
            if (residue == 0)
            {
                res.Add(new List<int>(dataList.ToArray()));
                return;
            }
            for (int i = start; i < len && residue - CombinationList[i] >= 0; i++)
            {
                dataList.Push(CombinationList[i]);
                // 【关键】因为元素可以重复使用，这里递归传递下去的是 i 而不是 i + 1
                findCombinationSum(residue - CombinationList[i], i, dataList);
                dataList.Pop();
            }

        }


     
    }
}
