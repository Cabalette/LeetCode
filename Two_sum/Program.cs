using System.Reflection;
using System;

namespace Two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //removeNthFromEnd(new ListNode(3), 4);

            MyLinkedList myLinkedList = new MyLinkedList() { val = 1, next = new MyLinkedList() { val = 3 } };
            myLinkedList.AddAtIndex(1, 2);
            myLinkedList.AddAtIndex(3, 4);
            myLinkedList.DeleteAtIndex(6);
            int a = 2;
        }
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public class MyLinkedList
        {
            public int val;
            public MyLinkedList? next;
            public MyLinkedList()
            {
                next = null;
            }
            public int GetLength(MyLinkedList pointer, int index)
            {
                int len = 1;
                while (pointer.next != null)
                {
                    pointer = pointer.next; len++;
                }
                return len;
            }

            public int Get(int index)
            {
                return 0;
            }

            public void AddAtHead(int val)
            {
                MyLinkedList myLinkedList = new MyLinkedList
                {
                    val = val,
                    next = this
                };
            }

            public void AddAtTail(int val)
            {
                MyLinkedList pointer = this;
                while (pointer.next != null)
                {
                    pointer = pointer.next;
                }
                pointer.next = new MyLinkedList() { val = val };
            }

            public void AddAtIndex(int index, int val)
            {
                MyLinkedList pointer = this;
                if (index == 0)  //first element
                {
                    pointer.AddAtHead(val);
                    return;
                }
                int len = pointer.GetLength(pointer, index);
                if (len == index)  // last element
                {
                    this.AddAtTail(val);
                    return;
                }
                else if (index > len) return;
                //int counter = 1;
                //while (pointer.next != null)
                //{
                //    pointer = pointer.next; counter++;
                //}
                //pointer = this;
                //if (index == counter)
                //{
                //    this.AddAtTail(val); return;
                //}
                //else if (index > counter) return;

                for (int i = 0; i < index - 1; i++)
                {
                    pointer = pointer.next;
                }
                pointer.next = new MyLinkedList() //random element
                {
                    val = val,
                    next = pointer.next
                };
            }

            public void DeleteAtIndex(int index)
            {
                MyLinkedList pointer = this;
                int len = pointer.GetLength(pointer, index);
                pointer = this;

                if (index == 0)
                {
                    if (len == 1)
                    {
                        pointer = null; return;
                    }
                    pointer.next = null;
                }

                if (index > len) return; //wrong index
                else if (index == len)  //last element
                {
                    for (int i = 1; i < len - 1; i++)
                    {
                        pointer = pointer.next;
                    }
                    pointer.next = null; return;
                }
                for (int i = 0; i < index - 1; i++)  //random index
                {
                    pointer = pointer.next;
                }
                pointer.next = pointer.next.next;

            }
        }
        static public ListNode removeNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head, slow = head;
            for (int i = 0; i < n; i++) fast = fast.next;
            if (fast == null) return head.next;
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}