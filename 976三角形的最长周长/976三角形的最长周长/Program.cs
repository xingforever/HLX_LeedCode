using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _976三角形的最长周长
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] data = new int[] {2,1,2};
            var res=solution.LargestPerimeter2(data);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int res = 0;
        public List<int> AList;
        //public List<List<int>> DATA = new List<List<int>>();
        public int LargestPerimeter(int[] A)
        {
            AList = A.ToList();
            AList.Sort();
            backtrace(0, new List<int>());
            return res;
        }

        public int LargestPerimeter2(int[] A)
        {
            var AList = A.ToList();
            AList.Sort();
            for (int i = AList.Count-3; i >=0 ; i--)
            {
                if ((AList[i]+ AList[i+1]> AList[i+2]))
                {
                     return AList[i] + AList[i + 1] + AList[i + 2];
                   
                }
            }
            return 0;
        }

        public void  backtrace(int begin, List<int> data)
        {
            if (data.Count == 3)
            {
                if (IsTran(data))
                {
                    int Perimeter = data[0] + data[1] + data[2];
                   // DATA.Add(new List<int>(data.ToArray()));
                    if (Perimeter>res)
                    {
                        res = Perimeter;
                    }
                }
                return;
            }
            for (int i = begin; i < AList.Count; i++)
            {
                data.Add(AList[begin]);
                begin +=1;
                backtrace(begin, data);
                data.RemoveAt(data.Count-1);
                
             

            }
        }
            

        public  bool IsTran(List<int> data)
        {
            data.Sort();
            if (data[0]+data[1]>data[2])
            {
                if (data[2]-data[1]<data[0])
                {
                    return true;
                }
            }
            //if ((data[0]+data[1]>data[2])&&(data[0]+data[2]>data[1])&&data[1]+data[2]>data[0])
            //{
            //    if (Math.Abs(data[0]-data[1])<data[2]&&(Math.Abs(data[0] - data[2]) < data[1])&&(Math.Abs(data[1] - data[2]) < data[0]))
            //    {
            //        return true;
            //    }
            //}
            return false;
          
        }
    }

}
