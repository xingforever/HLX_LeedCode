using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res=solution.Generate(5);
            Console.ReadLine();
            Console.ReadKey();
        }
    }


    public class Solution
    {
        public List<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows > 1 || numRows == 1)
            {
                res.Add(new List<int> { 1 });

            }
            if (numRows > 2 || numRows == 2)
            {
                res.Add(new List<int> { 1, 1 });

            }
           if (numRows >= 3)
            {              
               for (int i = 3; i <= numRows; i++)
                {
                    List<int> data = new List<int>();
                    data.Add(1);
                    var datares = GetData(i);
                    data.AddRange(datares);
                    data.Add(1);
                    res.Add(data);
                }               
            }
            else
            {
                ;
            }
            return res;           
        }      
        private List<int> GetData(int i)
        {
            var data = res[i-2];
            List<int> datares = new List<int>();
            for (int j= 0; j < data.Count-1; j++)
            {
                var a = data[j] + data[j + 1];
                datares.Add(a);
            }
            return datares;
        }

    }
}
