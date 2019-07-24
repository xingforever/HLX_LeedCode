using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78子集
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 2, 3 };
            solution.Subsets(nums);
        }
    }

    //https://leetcode-cn.com/problems/subsets/solution/hui-su-suan-fa-by-powcai-5/
    public class Solution
    {
        public List<IList<int>> res = new List<IList<int>>();
        public List<int> numsList = new List<int>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            numsList = nums.ToList();
            BackTrace(0, new List<int>());
           
            return res;
        }
        public void BackTrace(int begin,List<int>data)
        {
            var dataClone = new List<int>(data.ToArray());
             res.Add(dataClone);
            
            for (int i = begin; i < numsList.Count; i++)
            {
                data.Add(numsList[i]);
                begin += 1;
                BackTrace(begin,  data);
                data.RemoveAt(data.Count - 1);
            }
        }
    }
}
