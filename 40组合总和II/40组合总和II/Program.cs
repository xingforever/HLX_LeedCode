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
        public int Target;
        public IList<IList<int>> res = new List<IList<int>>();
     
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Candidates = candidates.ToList();
            Candidates.Sort();
            Target = target;
            backtrack(0,0, new List<int>());
            return res ;
        }

        public void backtrack(int sum,int beign, List<int>data)
        {
            if (sum==Target)
            {
                var datas = new List<int>(data.ToArray());
                res.Add(datas);
                
                              
                return;
            }
            if (sum>Target)
            {
                return;
            }
            for (int i = beign; i < Candidates.Count; i++)
            {
                var da = Candidates[i];

                if (i >= 1 && Candidates[i] == Candidates[i - 1])
                    continue;
                beign += 1;
                data.Add(da);
              
                backtrack(sum + da, beign, data);
                data.RemoveAt(data.Count - 1);
            }
        }
    }
}
