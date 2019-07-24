using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _657机器人能否返回原点
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int row = 0;
            int column = 0;
            //if (moves.Length==0)
            //{
            //    return true;
            //}
            //var stringList=moves.ToList();
            //int leftCount = stringList.Where(u => u == 'L').ToList().Count;
            //int rightCount = stringList.Where(u => u == 'R').ToList().Count;
            //if (leftCount!=rightCount)
            //{
            //    return false;
            //}
            //int upCount=stringList.Where(u => u == 'U').ToList().Count;
            //int downCount = stringList.Where(u => u == 'D').ToList().Count;
            //if (upCount!= downCount)
            //{
            //    return false;
            //}
            //return true;

            for (int i = 0; i < moves.Length; i++)
            {
                char da = moves[i];
                if (da == 'L')
                {
                    row -= 1;
                }
                else if (da == 'R')
                {
                    row += 1;
                }
                else if (da == 'U')
                {
                    column += 1;
                }
                else if (da == 'D')
                {
                    column -= 1;
                }
                else
                {
                    ;
                }
            }
            if (row == 0 && column == 0)
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
