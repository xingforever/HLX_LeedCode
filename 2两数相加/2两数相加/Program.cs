using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2两数相加
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ListNode1 = new ListNode(2);
            ListNode ListNode12 = new ListNode(4);
            ListNode ListNode13 = new ListNode(3);
            ListNode1.next = ListNode12;
            ListNode12.next = ListNode13;
            ListNode ListNode2 = new ListNode(5);
            ListNode ListNode22 = new ListNode(6);
            ListNode ListNode23 = new ListNode(4);
            ListNode2.next = ListNode22;
            ListNode22.next = ListNode23;
            Solution s1 = new Solution();
            var res = s1.AddTwoNumbers(ListNode1, ListNode2);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }


    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string sl1 = "", sl2 = "";
            var node1 = l1;
            var node2 = l2;
            while (node1.next != null)
            {
                sl1 += node1.val.ToString();
                node1 = node1.next;
            }
            sl1 += node1.val.ToString();
            while (node2.next != null)
            {
                sl2 += node2.val.ToString();
                node2 = node2.next;
            }
            sl2 += node2.val.ToString();
            string resl1 = new string(sl1.ToCharArray().Reverse().ToArray());
            long intl1 = long.Parse(resl1);
            string resl2 = new string(sl2.ToCharArray().Reverse().ToArray());
            long intl2 = long.Parse(resl2);
            long res = intl1 + intl2;
            string resString = res.ToString();
            ListNode s = null;
            ListNode head = null;
            int va = int.Parse(resString[resString.Length - 1].ToString());
            head = new ListNode(va);
            for (int i = 0; i < resString.Length - 1; i++)
            {
                int val = int.Parse(resString[i].ToString());
                s = new ListNode(val);
                s.next = head.next;
                head.next = s;

            }
            return head;

        }

        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            if (l1==null)
            {
                return l2;
            }
            if (l2==null)
            {
                return l1;
            }
            //计算头的值
            int v = l1.val + l2.val;
            if (v>9)
            {
                l1.val = v - 10;
                l1.next = addOne(l1.next);

            }
            else
            {
                l1.val = v;
            }
            l1.next = AddTwoNumbers2(l1.next, l2.next);
            return l1;

        }

        public ListNode addOne(ListNode node)
        {
            if (node==null)
            {
                return new ListNode(1);
            }
            if (node.val==9)
            {
                node.val = 0;
                node.next = addOne(node.next);
            }
            else
            {
                ++node.val;

            }
            return node;
        }
    }
}
