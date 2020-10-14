using System;

namespace Detect_Loop_in_LinkedList_and_remove_it
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(50);
            head.next = new ListNode(20);
            head.next.next = new ListNode(15);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(10);
            head.next.next.next.next.next = head.next.next;
            DetectCycleAndRemove(head);
            PrintList(head);
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        static void DetectCycleAndRemove(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    ListNode temp = head;
                    ListNode prev = fast;
                    while (temp != fast)
                    {
                        prev = fast;
                        temp = temp.next;
                        fast = fast.next;
                    }
                    prev.next = null;
                    break;
                }
            }
        }

        static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
        }
    }
}
