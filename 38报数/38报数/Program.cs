using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _38报数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string data = "1123144";
            var res=solution.CountAndSay(10);
            //Console.WriteLine(data);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            
            if (n==1)
            {
                return "1";
            }
            else
            {
                string res = CountAndSay(n-1);
                var theRes= GetCountString(res);
                return theRes;
            }
            
        }
        public  string GetCountString(string datas)
        {
            string res = "";
            int count = 1;
            int start = 0;
            int next = 1;
            while (start < datas.Length)
            {
                var data1 = datas[start];                
                while (next< datas.Length)
                {
                    var data2 = datas[next];
                    if (data1==data2)
                    {
                        count += 1;
                        next += 1;

                    }
                    else
                    {
                     
                        break;
                    }
                }
                res += count.ToString() + data1.ToString();
                start = next;
                next += 1;
                count = 1;
            }
            return res;
        }
    }
}
