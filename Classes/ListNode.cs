using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxConsoleApp.Classes
{
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

    public class ListNodeSequence
    {
        public static ListNode GetMockListNode(List<int> values)
        {
            ListNode result = new();
            ListNode next = result;

            for (int i = 0; i < values.Count; i++)
            {
                next.val = values[i];
                if (i != values.Count - 1)
                {
                    next.next = new ListNode();
                    next = next.next;
                }
            }
            return result;
        }

    }

    public class Solutions
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {

            if (head == null)
            {
                return null;
            }
            ListNode result = new ListNode();
            ListNode currentNode = result;
            ListNode prevNode = currentNode;

            while (head != null)
            {
                if (head.val == val)
                {
                    head = head.next;
                    continue;
                }

                currentNode.val = head.val;
                currentNode.next = head.next;
                prevNode = currentNode;
                currentNode = currentNode.next;
                head = head.next;
            }

            if (currentNode?.val == val && prevNode != null)
            {
                prevNode.next = null;
            }
            return result.val != 0 ? result : null;
        }

        //PrisonMike7's recursive solution
        public ListNode RemoveElements2(ListNode head, int val)
        {
            if (head == null) return null;
            head.next = RemoveElements2(head.next, val);
            return head.val == val ? head.next : head;
        }

        //parthbadani's 2 pointers solution. First node is dummy approach
        public ListNode RemoveElements3(ListNode head, int val)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prev = dummy;
            ListNode curr = head;

            while (curr != null)
            {
                if (curr.val == val)
                    prev.next = curr.next;
                else
                    prev = curr;
                curr = curr.next;
            }

            return dummy.next;
        }

    }
}
