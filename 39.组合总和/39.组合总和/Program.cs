using System;
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
        int Target;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            CombinationList = candidates.ToList();
            Target = target;
            BackTrace(0, new List<int>());
            return res;
        }

        public  void BackTrace(int begin,List<int>data)
        {           
            if (data.Count>Target)
            {
                return;
            }
            if (data.Count==Target)
            {
                res.Add(new List<int> (data.ToArray() )); ;
                return ;
            }
            while (data.Count< Target)
            {
                data.Add(CombinationList[begin]);
            }
            for (int i = begin; i < CombinationList.Count; i++)
            {
                data.Add(CombinationList[i]);
                BackTrace(i + 1, data);
                data.RemoveAt(data.Count - 1);
            }
        }
    }
}
