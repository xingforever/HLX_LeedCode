using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90子集2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3 };
            Solution solution = new Solution();
            var res=solution.Subsets(num);
            for (int i = 0; i < res.Count; i++)
            {
                var data = res[i];
            }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public List<IList<int>> res = new List<IList<int>>();
        public List<int> numsList = new List<int>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            numsList = nums.ToList();
            numsList.Sort();
            BackTrace(0, new List<int>());
            res.Add(numsList);
            return res;
        }
        public void BackTrace(int begin, List<int> data)
        {
            
            var dataClone = new List<int>(data.ToArray());
            res.Add(dataClone);


            for (int i = begin; i < numsList.Count; i++)
            {               
                if (i>begin&&numsList[i]==numsList[i-1])
                {
                    continue;
                }
                data.Add(numsList[i]);
                begin += 1;
                
                BackTrace(begin, data);
                data.RemoveAt(data.Count - 1);
            }
        }
    }
}
