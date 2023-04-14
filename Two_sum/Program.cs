using System.Reflection;
using System;

namespace Two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(23)
            {
                next = new ListNode(42)
                {
                    next = new ListNode(44)
                    {
                        next = new ListNode(44)
                        {

                        }
                    }
                }
            };
            ListNode listNode2 = new ListNode(1)
            {
                next = new ListNode(11)
                {
                    next = new ListNode(23)
                    {
                        next = new ListNode(42)
                        {

                        }
                    }
                }

            };
            ListNode res = MergeTwoLists(listNode1, listNode2);


            int a = 2;
        }
        public static ListNode? MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2 == null ? null : list2;
            else if (list2 == null) return list1;

            ListNode temp;
            ListNode small = list1.val <= list2.val ? list1 : list2;
            ListNode newSeq = small;
            ListNode big = small == list1 ? list2 : list1;

            while (small.next != null && big.next != null)
            {
                if (small.next.val <= big.val)
                {
                    small = small.next;
                    continue;
                }
                temp = small.next;
                small.next = big;
                small = small.next;
                big = temp;
            }
            if (small.next == null) small.next = big;
            else if (big.next == null)
            {
                while (small.next != null)
                {
                    if (small.next.val <= big.val)
                    {
                        small = small.next;
                        continue;
                    }
                    temp = small.next;
                    small.next = big;
                    small = small.next;
                    big = temp;
                }
                small.next = big;
            }
            return newSeq;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}