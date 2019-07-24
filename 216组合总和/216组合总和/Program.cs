using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216组合总和
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res = solution.CombinationSum3(3, 9);
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }

        public class Solution
        {
            public IList<IList<int>> res = new List<IList<int>>();
            public IList<IList<int>> CombinationSum3(int k, int n)
            {
                backtrack(k, n, 0, 1, new List<int>());
                return res;
            }


            public void backtrack(int k, int n, int sum, int begin, List<int> data)
            {
                if (k == 0)
                {
                    if (sum == n)
                    {
                        var datas = new List<int>(data.ToArray());

                        res.Add(datas);
                    }
                    return;
                }

                for (int i = begin; i < 10; i++)
                {
                    if (data.Contains(i))
                    {
                        continue;
                    }
                    if (data.Count>=1)
                    {
                        if (i<data[data.Count-1])
                        {
                            continue;
                        }
                    }   
                    data.Add(i);
                    backtrack(k - 1, n, sum + i, begin + 1, data);
                    data.RemoveAt(data.Count - 1);
                }

            }




        }
    }
}
