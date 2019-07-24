using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22括号生产
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res=solution.GenerateParenthesis(2);
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> ans = new List<string>();
            backtrack(ans, "", 0, 0, n);
            return ans;

        }
        /// <summary>
        /// 回溯算法
        /// </summary>
        /// <param name="ans"></param>
        /// <param name="cur"></param>
        /// <param name="open"></param>
        /// <param name="close"></param>
        /// <param name="max"></param>
        public void backtrack(List<string> ans, string cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                ans.Add(cur);
                return;
            }

            if (open < max)
                backtrack(ans, cur + "(", open + 1, close, max);
            if (close < open)
                backtrack(ans, cur + ")", open, close + 1, max);
        }

    }
}
