using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 旋转数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res =solution.RotatedDigits(20);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int RotatedDigits(int N)
        {
          
            int count=0;
            for (int i = 1; i <= N; i++)
            {
                if (Judge(i))
                {
                    count++;
                   
                }
            }
            return count;
        }

        public  bool  Judge(int x)
        {
            int n = x;
            int flag = 0;
            while (n>0)
            {
                int d = n % 10;
                if (d==3||d==4||d==7)
                {
                    return false;
                }
                if (flag>0||d==2||d==5||d==6||d==9)
                {
                    flag = 1;
                }
                n /= 10;
            }
            if (n==0&&flag>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
