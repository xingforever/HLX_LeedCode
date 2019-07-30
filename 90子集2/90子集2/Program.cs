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
            int[] num = new int[] { 1, 2 ,2};
            Solution solution = new Solution();
            var res=solution.SubsetsWithDup(num);
            for (int i = 0; i < res.Count; i++)
            {
                var data = res[i];
            }
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Solution
    {
        //先排序
        //按顺序添加
        //public List<IList<int>> res = new List<IList<int>>();
        //public List<int> numsList = new List<int>();
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();           
            var numsList = nums.ToList();
            numsList.Sort();
            BackTrace(numsList,0, new List<int>(), res);
           // res.Add(numsList);
            return res;
        }

        private void BackTrace(List<int> numsList, int begin, List<int> data, List<IList<int>> res)
        {
            var dataClone = new List<int>(data.ToArray());
            res.Add(dataClone);

            for (int i = begin; i < numsList.Count; i++)
            {
                if (i > begin && numsList[i] == numsList[i - 1])
                {
                    continue;
                }

                data.Add(numsList[i]);
                BackTrace(numsList,begin + 1, data, res);
                data.RemoveAt(data.Count - 1);
            }
        }

       

    }
}
